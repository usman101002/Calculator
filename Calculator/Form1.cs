using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);

            switch (comboBox1.Text)
            {
                case "+":
                    textBox3.Text = (a + b).ToString();
                    break;

                case "-":
                    textBox3.Text = (a - b).ToString();
                    break;

                case "*":
                    textBox3.Text = (a * b).ToString();
                    break;

                case "/":
                    if (b == 0)
                    {
                        MessageBox.Show("На ноль делить нельзя");
                    }
                    else
                    {
                        textBox3.Text = (a / b).ToString();
                    }
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
        }
    }
}
