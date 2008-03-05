using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            New,
            Queued,
            Synced,
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Draft,
            Done,
            Paused,
            Ready,
            New,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseGithubfarm = 7894;
        public const string BaseDepth = "standard-1";
        public const long SoftGithubfarm = 5606;
        public const string LimitBudget = "stable";
        public const double LimitGithubfarm = 63.34;
    }
}
