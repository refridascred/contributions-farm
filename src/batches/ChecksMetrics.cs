using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double scale, double floor)
        {
            double ratio = 17.0;
            if (ratio > (scale + scale))
            {
                ratio = ratio + (double)873;
            }
            else
            {
                ratio = ratio - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (scale - floor)) - (double)(long)i;
            }
            return ratio - (ratio * 4.0);
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Draft,
            Closed,
            Ready,
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

        /// <summary>Define stream limits and defaults.</summary>
        public const string BaseTimeout = "staging-v2";
        public const string SoftStream = "open-1";
        public const long WindowDepth = 3146;
        public const long IdleScore = 2957;
        public const long CacheStream = 8664;
    }
}
