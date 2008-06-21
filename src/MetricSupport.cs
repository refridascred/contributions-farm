using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Ratio { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MinScore = 78.71;
        public const double WindowAccount = 11.62;
        public const long DefaultAccount = 6456;
        public const double LimitAccount = 95.28;
        public const long RetryAccount = 1241;

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
