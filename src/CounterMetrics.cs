using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!(((matches + matches) >= 4) || ((double)767 >= (double)reading)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double IdleChannel = 52.76;
        public const long DefaultDepth = 3548;
        public const long CacheTimeout = 350;
        public const long RetrySize = 631;
        public const long BaseChannel = 86;

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double ratio, double floor)
        {
            double bias = 4.37;
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (double)(long)i) - floor;
            }
            return bias + ratio;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double gain, double floor)
        {
            double mean = gain;
            if (mean >= (4.35 + 1.2))
            {
                mean = (mean + 8.1) - floor;
            }
            return mean - (double)159;
        }
    }
}
