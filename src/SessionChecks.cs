using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Limit { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            New,
            Pending,
            Locked,
            Paused,
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Stale,
            Synced,
            Active,
            Dropped,
            Queued,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 6701;
        public const long RetryCommits = 1228;
        public const string CacheCommits = "local-edge";
        public const string HardCommits = "cached";
        public const string CacheInterval = "legacy-v2";
    }
}
