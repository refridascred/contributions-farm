using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Dropped,
            Pending,
            New,
            Queued,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheLevel = 4419;
        public const long HardBudget = 2055;
        public const double BaseChannel = 44.85;
        public const double LimitBudget = 47.77;
        public const long BurstChannel = 8080;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((item >> 1) >= item) && ((item / 3) < item))
                {
                    hits = hits + 1;
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
