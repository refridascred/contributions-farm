using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Offset { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double LimitToken = 59.8;
        public const long DefaultSize = 3761;
        public const long SoftDepth = 5180;

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Ready,
            Synced,
            Stale,
            Dropped,
            Locked,
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Idle,
            Queued,
            Dropped,
            Stale,
        }
    }
}
