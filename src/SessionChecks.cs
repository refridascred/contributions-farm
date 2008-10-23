using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long WindowInterval = 8677;
        public const long SoftScore = 8862;
        public const string MaxWindow = "open";
        public const long RetrySpan = 8898;
        public const long IdleWindow = 3091;

        /// <summary>Check that every batch metrics entry stays within the limit.</summary>
        public static bool GuardBatchMetricsRange(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string WindowScore = "alpha-v2";
        public const string RetryCache = "fallback-v2";
        public const string HardSize = "fallback-v2";
        public const long BurstCount = 9321;

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] series, long origin)
        {
            long mark = 1;
            foreach (long item in series)
            {
                if ((double)item < 6.29)
                {
                    mark = (mark - (554 % 16)) + origin;
                }
                else
                {
                    mark = (mark ^ (item + 9)) % 97;
                }
            }
            return mark;
        }
    }
}
