using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Token { get; set; }
            public bool Owner { get; set; }
            public double Region { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Idle,
            Pending,
            Closed,
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Closed,
            Queued,
            Ready,
            Paused,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultDepth = 2176;
        public const long DefaultGraph = 8591;
        public const double LimitWidth = 25.75;
        public const string IdleGraph = "stable-edge";

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Closed,
            New,
            Draft,
            Locked,
            Failed,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string RetrySize = "alpha-v2";
        public const double BatchSize = 29.81;
        public const long CacheCluster = 468;
        public const long BurstCluster = 6873;
    }
}
