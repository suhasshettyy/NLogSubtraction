using System;
using System.Collections.Generic;
using System.Text;

namespace Sum
{
    class Subtract
    {
        static NLog nLog = new NLog();
        public int Subtraction(int firstnumber, int secondnumber)
        {
            if (firstnumber == 0 || secondnumber == 0)
            {
                nLog.LogInfo("Subtraction method");
                nLog.LogDebug("Debug Successfull");
                nLog.LogWarn("First Number or Second Number is zero.");
                return 0;
            }
            else
            {
                int result = firstnumber - secondnumber;
                nLog.LogInfo("Subtraction method");
                nLog.LogDebug("Debug Successfull");
                nLog.LogWarn("Subtract Method Passed, Result : " + result);
                return result;
            }
        
        }
    }
}
