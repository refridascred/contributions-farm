using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string MaxWidth = "fallback";
        public const long RetryCluster = 8602;
        public const double CacheCount = 44.53;

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Ready,
            Failed,
            Locked,
            Queued,
            Dropped,
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Dropped,
            Closed,
            Retry,
            Done,
        }
    }
}
