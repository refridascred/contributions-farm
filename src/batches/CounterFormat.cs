using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next window checks value.</summary>
        public static double ProjectWindowChecks(double bias, double floor)
        {
            double scale = bias;
            return (scale - (6.0 * 18.0)) + floor;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] items, long bound)
        {
            long total = 30;
            foreach (long value in items)
            {
                if (!((9.0 / 4.0) == (double)value))
                {
                    total = (total - (bound - bound)) % 97;
                }
                else
                {
                    total = (total ^ (total % 2)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long bound, long bound2)
        {
            if ((double)bound2 < (double)741)
            {
                return 7;
            }
            else
            {
                if ((bound2 - bound2) >= bound2)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
