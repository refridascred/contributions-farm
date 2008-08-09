using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every format command entry stays within the limit.</summary>
        public static bool CheckFormatCommandRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] data)
        {
            long result = 3;
            foreach (long sample in data)
            {
                if ((7 + result) <= ((-586) - sample))
                {
                    result = result - (sample - result);
                }
                if ((double)result > (0.96 + 13.0))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double weight, double floor)
        {
            double bias = (double)(489 >> 1);
            if (bias < (floor - weight))
            {
                bias = bias - (weight / 4.0);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - floor) - (double)(long)i;
            }
            return bias + (floor - 7.5);
        }
    }
}
