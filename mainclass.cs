using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace individualAssignement1PROJ
{
    public class Mainclass : Form
    {
        private Button Btn_MachinesGuess;
        private Button button2;
        private Button button3;
        private Button button4;

        

        private void InitializeComponent()
        {
            this.Btn_MachinesGuess = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_MachinesGuess
            // 
            this.Btn_MachinesGuess.Location = new System.Drawing.Point(137, 34);
            this.Btn_MachinesGuess.Name = "Btn_MachinesGuess";
            this.Btn_MachinesGuess.Size = new System.Drawing.Size(120, 53);
            this.Btn_MachinesGuess.TabIndex = 0;
            this.Btn_MachinesGuess.Text = "MACHINE\'S GUESS";
            this.Btn_MachinesGuess.UseVisualStyleBackColor = true;
            this.Btn_MachinesGuess.Click += new System.EventHandler(this.MachinesGuess_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(46, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 59);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(158, 122);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 59);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(278, 122);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 59);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Mainclass
            // 
            this.ClientSize = new System.Drawing.Size(411, 270);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Btn_MachinesGuess);
            this.Name = "Mainclass";
            this.ResumeLayout(false);

        }

        public Mainclass()
        {
            InitializeComponent();
        }
        public static void Main()
        {
            Mainclass MainSRFN = new Mainclass();
            Application.Run(MainSRFN);
        }


        private void MachinesGuess_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
