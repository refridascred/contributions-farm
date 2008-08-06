using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Active,
            Stale,
            Closed,
            Synced,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string IdleGithubfarm = "latest-edge";
        public const double CacheLevel = 41.08;
        public const double MaxGithubfarm = 75.87;
        public const long HardGithubfarm = 2734;

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }
    }
}
