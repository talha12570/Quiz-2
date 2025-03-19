using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Semester 1 GPA
            
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Semester 2 GPA
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //Semester 3 GPA
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //Semester 4 GPA
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Calculate CGPA button
            double input1 = Convert.ToDouble(textBox1.Text);
            double input2 = Convert.ToDouble(textBox2.Text);
            double input3 = Convert.ToDouble(textBox3.Text);
            double input4 = Convert.ToDouble(textBox4.Text);
            double result = (input1 + input2 + input3 + input4) / 4;
            textBox5.Text = result.ToString();
            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
