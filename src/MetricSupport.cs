using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Draft,
            Synced,
            Done,
            Idle,
            Queued,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitBudget = 15.38;
        public const long BurstGithubfarm = 7736;
        public const long CacheGithubfarm = 3418;
        public const double IdleGithubfarm = 85.57;

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
