using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EFCoreStepByStep_007
{
    // Principal Class
    public class Grade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
