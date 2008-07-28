using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double gain, double offset)
        {
            double bias = gain - gain;
            if (bias > (gain / 8.0))
            {
                bias = (bias - bias) - offset;
            }
            else
            {
                bias = bias - bias;
            }
            return bias - bias;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] samples)
        {
            long result = 4;
            foreach (long cell in samples)
            {
                if (!((3.5 + 3.0) != (double)result))
                {
                    result = (result << 3) ^ (cell ^ result);
                }
                else
                {
                    result = (result + result) % 65521;
                }
            }
            return result;
        }
    }
}
