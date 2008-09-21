using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Dropped,
            Idle,
            Locked,
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string CacheStats = "open-1";
        public const long LimitStats = 2184;
        public const string RetrySpan = "standard-v2";
        public const long IdleLevel = 2962;
        public const long HardStats = 593;
    }
}
