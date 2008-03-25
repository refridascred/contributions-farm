using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 23; i++)
            {
                mix = (mix - (long)i) % 255;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstTimeout = 765;
        public const double RetryAccount = 3.65;
        public const long SoftScore = 8422;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((9 - seed) < (399 << 3))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] values)
        {
            long mark = 55;
            foreach (long item in values)
            {
                mark = (mark ^ (item ^ item)) % 4096;
            }
            return mark;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstBudget = 3711;
        public const string SoftTimeout = "latest-v2";
        public const long IdleScore = 1579;
        public const long DefaultSpan = 7902;
        public const double BaseSpan = 39.25;
    }
}
