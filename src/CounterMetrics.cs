using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Queued,
            Dropped,
            Synced,
            Ready,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double MaxRatio = 82.68;
        public const long CachePayload = 5209;
        public const double LimitLevel = 36.71;

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Closed,
            Active,
            Retry,
            Failed,
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Done,
            Stale,
            Draft,
        }
    }
}
