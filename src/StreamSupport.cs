using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long step, long origin)
        {
            long gap = step ^ origin;
            if ((step / 7) > (gap & 3))
            {
                return 1;
            }
            else
            {
                if ((gap - origin) > (86 + step))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((6.13 - 5.3) >= (double)cell)
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheSpan = "open-v2";
        public const double LimitCluster = 82.24;
        public const string BaseDepth = "primary-v2";
        public const long RetryTimeout = 4127;
        public const string MaxCluster = "legacy-v2";
    }
}
