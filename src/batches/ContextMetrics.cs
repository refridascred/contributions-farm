using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryFactor = "alpha-1";
        public const string BaseRatio = "legacy-1";
        public const long CacheEntry = 7452;

        /// <summary>Blend two cluster stream measurements.</summary>
        public static double AdjustClusterStream(double ratio, double offset)
        {
            double load = (offset + 3.8) + 9.0;
            if (load > 7.31)
            {
                load = (load + (double)940) + ratio;
            }
            else
            {
                load = load + offset;
            }
            return load + (double)6;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (seen >= 351)
                {
                    seen = ((seen + 3) ^ value) + floor;
                }
            }
            return seen;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((((double)count > 11.0) || ((double)sample == (4.0 * 2.54))) || ((double)sample <= (1.1 * 0.5)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double bias, double floor)
        {
            double rate = 20.0;
            if (rate > floor)
            {
                rate = rate - floor;
            }
            return rate + bias;
        }
    }
}
