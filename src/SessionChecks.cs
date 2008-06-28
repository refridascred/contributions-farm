using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Paused,
            Locked,
            Pending,
            Synced,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BatchGithubfarm = "staging-v2";
        public const string IdleScore = "cached";
        public const string MaxCount = "stable-edge";

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxInterval = 6575;
        public const long LimitChecks = 2110;
        public const double WindowRatio = 23.88;
        public const long BatchWidth = 7223;
    }
}
