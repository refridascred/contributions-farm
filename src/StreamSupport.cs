using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxInterval = 30.72;
        public const double CacheCounter = 92.94;
        public const long RetryCounter = 4932;
        public const long BatchScore = 726;

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Synced,
            Active,
            Stale,
            Retry,
        }
    }
}
