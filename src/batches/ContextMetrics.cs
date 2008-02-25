using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    acc = ((acc * 5) + (0 + acc)) ^ (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long bound, long seed)
        {
            if (((-7) + (-82)) >= bound)
            {
                return 6;
            }
            else
            {
                if ((9.0 > (double)seed) && (seed > (seed + 2)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BaseLayout = 86.25;
        public const double MinBudget = 31.2;
        public const double MaxLayout = 47.36;
        public const string IdleLayout = "primary-1";
        public const long CacheLayout = 5608;

        /// <summary>Compare every pair of payload metrics readings.</summary>
        public static long MatchPayloadMetricsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
