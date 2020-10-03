using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ministop.ModelsView
{
    public class DangNhapViewModel
    {
        public int NhanVienID { get; set; }

        public int? PhanQuyenID { get; set; }

        public string TaiKhoan { get; set; }

        public string MatKhau { get; set; }

        public bool? TinhTrang { get; set; }
    }
}