using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Total { get; set; }
            public long Owner { get; set; }
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Failed,
            Ready,
            Stale,
            Dropped,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdlePayload = 5420;
        public const string MaxDepth = "alpha";
        public const long WindowInterval = 8202;
        public const string BatchPayload = "stable-v2";
        public const double MinScore = 78.34;
    }
}
