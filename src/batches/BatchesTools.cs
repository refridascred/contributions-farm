using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long limit, long offset)
        {
            if ((double)limit >= (6.14 * 8.6))
            {
                return 7;
            }
            else
            {
                if ((5.2 - 5.9) >= (double)offset)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double bias, double floor)
        {
            double bias2 = (floor / 5.0) - 2.2;
            if (bias2 >= bias)
            {
                bias2 = bias2 + (double)(-230);
            }
            return bias2 + (bias * 1.0);
        }
    }
}
