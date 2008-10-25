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

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftDepth = 1208;
        public const long StepSpan = 5526;
        public const long LimitCounter = 1897;

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
