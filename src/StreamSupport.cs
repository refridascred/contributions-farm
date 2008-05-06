using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Active,
            Draft,
            Retry,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string WindowGithubfarm = "latest-edge";
        public const string DefaultScore = "open-1";
        public const string HardGithubfarm = "cached";
        public const long CacheGithubfarm = 1756;

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Paused,
            Synced,
            Ready,
            Retry,
        }
    }
}
