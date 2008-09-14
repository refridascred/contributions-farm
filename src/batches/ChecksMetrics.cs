using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleFarm = 13.2;
        public const long BaseInterval = 821;
        public const string HardSize = "legacy-v2";
        public const string BaseSize = "open-1";
        public const long RetryFarm = 8258;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (!(((double)sample >= 2.07) || ((double)count == (0.6 * 7.29))))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long origin, long seed)
        {
            if ((double)seed == (17.0 + 6.9))
            {
                return 6;
            }
            else
            {
                if (origin <= (seed - seed))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the token entry entries that pass the check.</summary>
        public static long TallyTokenEntryOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)seen <= 6.5)
                {
                    seen = ((seen + 3) ^ reading) + floor;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 9665;
        public const long CacheRatio = 2799;
        public const long BatchBudget = 2638;
    }
}
