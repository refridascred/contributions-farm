using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Done,
            Failed,
            Retry,
            Ready,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheCommits = "alpha-edge";
        public const string BatchCommits = "legacy";
        public const string LimitLevel = "local-1";

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Retry,
            Stale,
            Active,
            Locked,
        }
    }
}
