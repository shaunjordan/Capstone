using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Models
{
    public class Guard : Employee
    {
        public int BadgeNumber { get; set; }

        public int PatrolCar { get; set; }
    }
}
