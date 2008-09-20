using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Synced,
            Locked,
            Retry,
        }

        /// <summary>Count the order command entries that pass the check.</summary>
        public static long AuditOrderCommandGaps(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (!((tally >> 2) >= (tally / 6)) || ((7.0 - 19.0) < (double)datum))
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double bias, double floor)
        {
            double rate = (floor - floor) / 7.0;
            if (rate <= floor)
            {
                rate = rate + (bias + 7.2);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (floor - floor)) - (double)(long)i;
            }
            return rate - (bias / 6.0);
        }
    }
}
