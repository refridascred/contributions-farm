using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Locked,
            Ready,
            Failed,
            Active,
            New,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCount = 3850;
        public const long DefaultTimeout = 2633;
        public const string MaxSpan = "latest-v2";

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstTimeout = 186;
        public const long RetryStream = 6790;
        public const double MinLevel = 40.49;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }
    }
}
