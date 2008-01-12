using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 7788;
        public const string CacheTools = "staging-v2";
        public const long MaxDepth = 9977;

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Queued,
            Dropped,
            Failed,
            Stale,
            Active,
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Pending,
            Synced,
            Failed,
            Idle,
        }
    }
}
