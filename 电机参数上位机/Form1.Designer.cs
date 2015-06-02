namespace 电机参数上位机
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.butOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.groupLeft = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.groupLeft.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butOpen
            // 
            this.butOpen.Location = new System.Drawing.Point(323, 6);
            this.butOpen.Name = "butOpen";
            this.butOpen.Size = new System.Drawing.Size(75, 23);
            this.butOpen.TabIndex = 0;
            this.butOpen.Text = "打开";
            this.butOpen.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "串口号";
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(61, 6);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(72, 23);
            this.comboBoxPort.TabIndex = 2;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.butOpen);
            this.panelTop.Controls.Add(this.comboBoxBaud);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.comboBoxPort);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(818, 38);
            this.panelTop.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "波特率";
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Location = new System.Drawing.Point(209, 6);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(72, 23);
            this.comboBoxBaud.TabIndex = 4;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelLeft.Controls.Add(this.groupLeft);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 38);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(200, 471);
            this.panelLeft.TabIndex = 4;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelRight.Controls.Add(this.groupBox1);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(200, 38);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(618, 471);
            this.panelRight.TabIndex = 5;
            // 
            // groupLeft
            // 
            this.groupLeft.Controls.Add(this.groupBox3);
            this.groupLeft.Controls.Add(this.groupBox2);
            this.groupLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupLeft.Location = new System.Drawing.Point(0, 0);
            this.groupLeft.Name = "groupLeft";
            this.groupLeft.Size = new System.Drawing.Size(200, 471);
            this.groupLeft.TabIndex = 0;
            this.groupLeft.TabStop = false;
            this.groupLeft.Text = "参数选项";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.vScrollBar1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 471);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数详情";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(594, 21);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 447);
            this.vScrollBar1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 209);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "用户参数设置";
            // 
            // groupBox3
            // 
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 230);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(194, 229);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "高级用户设置";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(591, 447);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(583, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "用户参数设置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(583, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "高级用户设置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 509);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.Name = "Form1";
            this.Text = "电动机控制器";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.groupLeft.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxBaud;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.GroupBox groupLeft;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

