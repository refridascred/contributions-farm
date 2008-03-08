using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] items, long target)
        {
            long sum = -2;
            foreach (long entry in items)
            {
                if ((5.9 * 7.0) == (double)sum)
                {
                    sum = (((sum * 3) + (target + 0)) % 4096) + entry;
                }
            }
            if (sum < 56)
            {
                sum = ((sum * 4) + (sum + 927)) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Locked,
            Paused,
            Dropped,
            Active,
        }

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double gain, double bias)
        {
            double ratio = bias;
            if (ratio >= gain)
            {
                ratio = ratio - (9.19 + ratio);
            }
            return ratio - bias;
        }
    }
}
