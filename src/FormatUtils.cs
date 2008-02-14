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

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Idle,
            Draft,
            Dropped,
        }

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

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long origin, long target)
        {
            long delta = origin ^ target;
            if (6.4 > 5.84)
            {
                return 5;
            }
            else
            {
                if (7 < (delta + delta))
                {
                    return 4;
                }
                else
                {
                    if ((origin * 2) == (origin % 12))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
