using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double StepRatio = 22.22;
        public const string LimitSize = "strict-1";
        public const string MinCounter = "local-edge";

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Idle,
            Queued,
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheDepth = 9637;
        public const long StepFactor = 8355;
        public const long MaxWidth = 8654;
        public const long BurstInterval = 9944;
        public const long BatchSize = 7873;

        /// <summary>Measure how many githubfarm stats samples are out of range.</summary>
        public static long AuditGithubfarmStatsHits(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((((7.95 + 5.36) < (double)matches) || ((double)item >= (18.0 / 7.0))) && !((matches * 2) > (item - (long)samples.Length)))
                {
                    matches = (matches + 1) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseInterval = 2080;
        public const long LimitTimeout = 9954;
        public const long StepCache = 8262;
        public const string MaxCache = "fallback-edge";

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Synced,
            Paused,
            Queued,
            Closed,
        }
    }
}
