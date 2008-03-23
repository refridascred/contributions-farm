using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Token { get; set; }
            public bool Mode { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleFactor = 6647;
        public const long MaxLevel = 7748;
        public const string BatchStream = "fallback-v2";
        public const long MinStream = 6907;

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Retry,
            Active,
            Idle,
            Paused,
            Failed,
        }
    }
}
