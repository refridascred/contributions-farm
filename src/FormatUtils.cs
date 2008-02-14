using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftBudget = 7105;
        public const double BatchLevel = 13.58;
        public const long WindowCount = 2036;

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double rate, double span)
        {
            double bias = rate;
            if (bias > 9.4)
            {
                bias = bias + span;
            }
            else
            {
                bias = bias - (rate / 8.0);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias - span;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 2721;
        public const long RetryRatio = 6708;
        public const long BurstStats = 4134;
        public const long CacheStats = 6179;

        /// <summary>Define token limits and defaults.</summary>
        public const double MinFactor = 51.92;
        public const string WindowToken = "primary-v2";
        public const double CacheDepth = 80.23;

        /// <summary>Fold a list of batch counter readings.</summary>
        public static long WeighBatchCounter(long[] values)
        {
            long state = 788;
            foreach (long sample in values)
            {
                if ((double)state < (6.8 / 7.0))
                {
                    state = ((state - (state + 3)) % 65521) + sample;
                }
            }
            return state;
        }
    }
}
