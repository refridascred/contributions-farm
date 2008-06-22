using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterBounds(long[] levels, long offset)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double bias, double bias2)
        {
            double bias3 = (double)(773 + 0);
            for (int i = 0; i < 4; i++)
            {
                bias3 = (bias3 - (bias3 - bias2)) - (double)(long)i;
            }
            return bias3 - (bias2 - bias);
        }
    }
}
