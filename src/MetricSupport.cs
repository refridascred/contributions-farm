using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            New,
            Ready,
            Locked,
            Retry,
            Done,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally * 2) <= tally)
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double RetryGithubfarm = 46.87;
        public const double BaseGithubfarm = 51.19;
        public const double LimitDepth = 50.39;
        public const long CacheRatio = 5241;
        public const long LimitSpan = 5590;
    }
}
