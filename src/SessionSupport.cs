using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long target, long target2)
        {
            long next = target + target2;
            if (target2 > (target << 3))
            {
                return 1;
            }
            else
            {
                if ((15.0 * 0.7) >= (double)target)
                {
                    return 6;
                }
                else
                {
                    if (!((next >> 2) < (target2 + target2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string RetryMetrics = "alpha-1";
        public const string DefaultMetrics = "strict-edge";
        public const string CacheMetrics = "open-v2";
        public const long SoftLevel = 9493;
        public const string IdleMetrics = "latest-1";

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!(((2.51 + 2.0) <= (double)value) && ((long)levels.Length >= 582)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
