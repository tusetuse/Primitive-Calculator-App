using System;
using System.Data;

using System.Windows.Forms;

namespace Cvicenie1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("7");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("9");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("0");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(".");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                string newText = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                textBox1.Text = newText;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("²");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("√");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("8");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("/");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("4");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("5");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("6");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("*");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("1");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("2");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("3");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("-");
        }
        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("+");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string expression = textBox1.Text;

            if (expression.Contains("√"))
            {
                int sqrtIndex = expression.IndexOf('√');
                if (sqrtIndex != -1)
                {
                    string numberAfterSqrt = expression.Substring(sqrtIndex + 1);
                    double sqrtResult = Math.Sqrt(Convert.ToDouble(numberAfterSqrt));
                    expression = expression.Substring(0, sqrtIndex) + sqrtResult.ToString();
                }
            }

            if (expression.Contains("²"))
            {
                int powIndex = expression.IndexOf('²');
                if (powIndex != -1)
                {
                    string numberBeforePow = expression.Substring(0, powIndex);
                    double powResult = Math.Pow(Convert.ToDouble(numberBeforePow), 2);
                    expression = powResult.ToString() + expression.Substring(powIndex + 1);
                }
            }

            try
            {
                DataTable table = new DataTable();
                object result = table.Compute(expression, "");
                textBox1.AppendText("=" + Convert.ToString(result));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid expression: " + ex.Message);
            }
        }

    }
}