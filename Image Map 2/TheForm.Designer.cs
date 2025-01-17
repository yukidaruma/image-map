﻿namespace Image_Map
{
    partial class TheForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheForm));
            this.JavaWorldButton = new System.Windows.Forms.Button();
            this.SelectWorldLabel = new System.Windows.Forms.Label();
            this.BedrockWorldButton = new System.Windows.Forms.Button();
            this.ExistingTab = new System.Windows.Forms.TabPage();
            this.ExistingControls = new System.Windows.Forms.Panel();
            this.PlayerSelector = new System.Windows.Forms.ComboBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddInventoryButton = new System.Windows.Forms.Button();
            this.ExportImageButton = new System.Windows.Forms.Button();
            this.ExistingZone = new System.Windows.Forms.FlowLayoutPanel();
            this.ImportTab = new System.Windows.Forms.TabPage();
            this.ImportControls = new System.Windows.Forms.Panel();
            this.AddChestCheck = new System.Windows.Forms.CheckBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.ImportZone = new System.Windows.Forms.FlowLayoutPanel();
            this.MapView = new System.Windows.Forms.TabControl();
            this.SelectAllCheck = new System.Windows.Forms.CheckBox();
            this.MapViewZone = new System.Windows.Forms.Panel();
            this.ExistingTab.SuspendLayout();
            this.ExistingControls.SuspendLayout();
            this.ImportTab.SuspendLayout();
            this.ImportControls.SuspendLayout();
            this.MapView.SuspendLayout();
            this.MapViewZone.SuspendLayout();
            this.SuspendLayout();
            // 
            // JavaWorldButton
            // 
            this.JavaWorldButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.JavaWorldButton.Location = new System.Drawing.Point(11, 10);
            this.JavaWorldButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.JavaWorldButton.Name = "JavaWorldButton";
            this.JavaWorldButton.Size = new System.Drawing.Size(158, 92);
            this.JavaWorldButton.TabIndex = 0;
            this.JavaWorldButton.Text = "Java World";
            this.JavaWorldButton.UseVisualStyleBackColor = true;
            this.JavaWorldButton.Click += new System.EventHandler(this.JavaWorldButton_Click);
            // 
            // SelectWorldLabel
            // 
            this.SelectWorldLabel.AutoSize = true;
            this.SelectWorldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.SelectWorldLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.SelectWorldLabel.Location = new System.Drawing.Point(305, 36);
            this.SelectWorldLabel.Name = "SelectWorldLabel";
            this.SelectWorldLabel.Size = new System.Drawing.Size(458, 156);
            this.SelectWorldLabel.TabIndex = 17;
            this.SelectWorldLabel.Text = "← Click Here!\r\n\r\nMaps will show up in this\r\narea once you select a world.";
            // 
            // BedrockWorldButton
            // 
            this.BedrockWorldButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.BedrockWorldButton.Location = new System.Drawing.Point(11, 114);
            this.BedrockWorldButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BedrockWorldButton.Name = "BedrockWorldButton";
            this.BedrockWorldButton.Size = new System.Drawing.Size(158, 92);
            this.BedrockWorldButton.TabIndex = 21;
            this.BedrockWorldButton.Text = "Bedrock World";
            this.BedrockWorldButton.UseVisualStyleBackColor = true;
            this.BedrockWorldButton.Click += new System.EventHandler(this.BedrockWorldButton_Click);
            // 
            // ExistingTab
            // 
            this.ExistingTab.Controls.Add(this.ExistingControls);
            this.ExistingTab.Controls.Add(this.ExistingZone);
            this.ExistingTab.Location = new System.Drawing.Point(4, 38);
            this.ExistingTab.Name = "ExistingTab";
            this.ExistingTab.Padding = new System.Windows.Forms.Padding(3);
            this.ExistingTab.Size = new System.Drawing.Size(785, 410);
            this.ExistingTab.TabIndex = 0;
            this.ExistingTab.Text = "Existing Maps";
            this.ExistingTab.UseVisualStyleBackColor = true;
            // 
            // ExistingControls
            // 
            this.ExistingControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExistingControls.Controls.Add(this.PlayerSelector);
            this.ExistingControls.Controls.Add(this.DeleteButton);
            this.ExistingControls.Controls.Add(this.AddInventoryButton);
            this.ExistingControls.Controls.Add(this.ExportImageButton);
            this.ExistingControls.Location = new System.Drawing.Point(7, 343);
            this.ExistingControls.Name = "ExistingControls";
            this.ExistingControls.Size = new System.Drawing.Size(770, 61);
            this.ExistingControls.TabIndex = 5;
            // 
            // PlayerSelector
            // 
            this.PlayerSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlayerSelector.FormattingEnabled = true;
            this.PlayerSelector.Location = new System.Drawing.Point(413, 12);
            this.PlayerSelector.Name = "PlayerSelector";
            this.PlayerSelector.Size = new System.Drawing.Size(219, 37);
            this.PlayerSelector.TabIndex = 23;
            this.PlayerSelector.SelectedIndexChanged += new System.EventHandler(this.PlayerSelector_SelectedIndexChanged);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.DeleteButton.Location = new System.Drawing.Point(638, 3);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(119, 53);
            this.DeleteButton.TabIndex = 19;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddInventoryButton
            // 
            this.AddInventoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.AddInventoryButton.Location = new System.Drawing.Point(199, 3);
            this.AddInventoryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddInventoryButton.Name = "AddInventoryButton";
            this.AddInventoryButton.Size = new System.Drawing.Size(208, 53);
            this.AddInventoryButton.TabIndex = 18;
            this.AddInventoryButton.Text = "Add to Inventory";
            this.AddInventoryButton.UseVisualStyleBackColor = true;
            this.AddInventoryButton.Click += new System.EventHandler(this.AddInventoryButton_Click);
            // 
            // ExportImageButton
            // 
            this.ExportImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ExportImageButton.Location = new System.Drawing.Point(3, 3);
            this.ExportImageButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExportImageButton.Name = "ExportImageButton";
            this.ExportImageButton.Size = new System.Drawing.Size(190, 53);
            this.ExportImageButton.TabIndex = 17;
            this.ExportImageButton.Text = "Export Image";
            this.ExportImageButton.UseVisualStyleBackColor = true;
            this.ExportImageButton.Click += new System.EventHandler(this.ExportImageButton_Click);
            // 
            // ExistingZone
            // 
            this.ExistingZone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExistingZone.AutoScroll = true;
            this.ExistingZone.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ExistingZone.Location = new System.Drawing.Point(6, 5);
            this.ExistingZone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExistingZone.Name = "ExistingZone";
            this.ExistingZone.Size = new System.Drawing.Size(771, 333);
            this.ExistingZone.TabIndex = 2;
            // 
            // ImportTab
            // 
            this.ImportTab.Controls.Add(this.ImportControls);
            this.ImportTab.Controls.Add(this.ImportZone);
            this.ImportTab.Location = new System.Drawing.Point(4, 38);
            this.ImportTab.Name = "ImportTab";
            this.ImportTab.Padding = new System.Windows.Forms.Padding(3);
            this.ImportTab.Size = new System.Drawing.Size(785, 410);
            this.ImportTab.TabIndex = 1;
            this.ImportTab.Text = "Import Maps";
            this.ImportTab.UseVisualStyleBackColor = true;
            // 
            // ImportControls
            // 
            this.ImportControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImportControls.Controls.Add(this.AddChestCheck);
            this.ImportControls.Controls.Add(this.SendButton);
            this.ImportControls.Controls.Add(this.OpenButton);
            this.ImportControls.Location = new System.Drawing.Point(7, 343);
            this.ImportControls.Name = "ImportControls";
            this.ImportControls.Size = new System.Drawing.Size(770, 61);
            this.ImportControls.TabIndex = 4;
            // 
            // AddChestCheck
            // 
            this.AddChestCheck.AutoSize = true;
            this.AddChestCheck.Checked = true;
            this.AddChestCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AddChestCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AddChestCheck.Location = new System.Drawing.Point(365, 17);
            this.AddChestCheck.Name = "AddChestCheck";
            this.AddChestCheck.Size = new System.Drawing.Size(269, 29);
            this.AddChestCheck.TabIndex = 5;
            this.AddChestCheck.Text = "Add new maps to inventory";
            this.AddChestCheck.UseVisualStyleBackColor = true;
            // 
            // SendButton
            // 
            this.SendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SendButton.Location = new System.Drawing.Point(138, 3);
            this.SendButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(212, 53);
            this.SendButton.TabIndex = 18;
            this.SendButton.Text = "Send All to World";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.OpenButton.Location = new System.Drawing.Point(3, 3);
            this.OpenButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(129, 53);
            this.OpenButton.TabIndex = 17;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // ImportZone
            // 
            this.ImportZone.AllowDrop = true;
            this.ImportZone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImportZone.AutoScroll = true;
            this.ImportZone.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ImportZone.Location = new System.Drawing.Point(7, 5);
            this.ImportZone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ImportZone.Name = "ImportZone";
            this.ImportZone.Size = new System.Drawing.Size(771, 333);
            this.ImportZone.TabIndex = 3;
            this.ImportZone.DragDrop += new System.Windows.Forms.DragEventHandler(this.ImportZone_DragDrop);
            this.ImportZone.DragEnter += new System.Windows.Forms.DragEventHandler(this.ImportZone_DragEnter);
            // 
            // MapView
            // 
            this.MapView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MapView.Controls.Add(this.ImportTab);
            this.MapView.Controls.Add(this.ExistingTab);
            this.MapView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.MapView.Location = new System.Drawing.Point(0, 0);
            this.MapView.Name = "MapView";
            this.MapView.SelectedIndex = 0;
            this.MapView.Size = new System.Drawing.Size(793, 452);
            this.MapView.TabIndex = 16;
            // 
            // SelectAllCheck
            // 
            this.SelectAllCheck.AutoSize = true;
            this.SelectAllCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SelectAllCheck.Location = new System.Drawing.Point(321, 7);
            this.SelectAllCheck.Name = "SelectAllCheck";
            this.SelectAllCheck.Size = new System.Drawing.Size(102, 24);
            this.SelectAllCheck.TabIndex = 5;
            this.SelectAllCheck.Text = "Select All";
            this.SelectAllCheck.UseVisualStyleBackColor = true;
            this.SelectAllCheck.CheckedChanged += new System.EventHandler(this.SelectAllCheck_CheckedChanged);
            // 
            // MapViewZone
            // 
            this.MapViewZone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MapViewZone.Controls.Add(this.SelectAllCheck);
            this.MapViewZone.Controls.Add(this.MapView);
            this.MapViewZone.Location = new System.Drawing.Point(175, 12);
            this.MapViewZone.Name = "MapViewZone";
            this.MapViewZone.Size = new System.Drawing.Size(793, 452);
            this.MapViewZone.TabIndex = 5;
            this.MapViewZone.Visible = false;
            // 
            // TheForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 464);
            this.Controls.Add(this.BedrockWorldButton);
            this.Controls.Add(this.JavaWorldButton);
            this.Controls.Add(this.MapViewZone);
            this.Controls.Add(this.SelectWorldLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(400, 250);
            this.Name = "TheForm";
            this.Text = "Image Map";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TheForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TheForm_FormClosed);
            this.Load += new System.EventHandler(this.TheForm_Load);
            this.ExistingTab.ResumeLayout(false);
            this.ExistingControls.ResumeLayout(false);
            this.ImportTab.ResumeLayout(false);
            this.ImportControls.ResumeLayout(false);
            this.ImportControls.PerformLayout();
            this.MapView.ResumeLayout(false);
            this.MapViewZone.ResumeLayout(false);
            this.MapViewZone.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button JavaWorldButton;
        public System.Windows.Forms.Label SelectWorldLabel;
        public System.Windows.Forms.Button BedrockWorldButton;
        public System.Windows.Forms.TabPage ExistingTab;
        public System.Windows.Forms.Panel ExistingControls;
        public System.Windows.Forms.Button DeleteButton;
        public System.Windows.Forms.Button AddInventoryButton;
        public System.Windows.Forms.Button ExportImageButton;
        public System.Windows.Forms.FlowLayoutPanel ExistingZone;
        public System.Windows.Forms.TabPage ImportTab;
        public System.Windows.Forms.Panel ImportControls;
        public System.Windows.Forms.Button SendButton;
        public System.Windows.Forms.Button OpenButton;
        public System.Windows.Forms.FlowLayoutPanel ImportZone;
        public System.Windows.Forms.TabControl MapView;
        public System.Windows.Forms.ComboBox PlayerSelector;
        private System.Windows.Forms.CheckBox AddChestCheck;
        private System.Windows.Forms.CheckBox SelectAllCheck;
        public System.Windows.Forms.Panel MapViewZone;
    }
}

