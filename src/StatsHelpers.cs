using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchRatio = 7532;
        public const long RetryCount = 1402;
        public const double BurstLevel = 97.39;
        public const long MaxSpan = 3420;
        public const long MaxLevel = 452;

        /// <summary>Audit cluster batches readings against a rule.</summary>
        public static long AuditClusterBatchesOutliers(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (matches >= (matches >> 4))
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Locked,
            Active,
            New,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 5758;
        public const long BurstMetric = 4810;
        public const long CacheMetric = 9191;
        public const double CacheBudget = 84.11;
        public const string BatchBudget = "primary-v2";

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!(((cell * 2) == (cell ^ count)) || ((965 & 127) <= cell)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
