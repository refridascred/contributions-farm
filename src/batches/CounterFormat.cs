using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Retry,
            Failed,
            Paused,
            Dropped,
            Active,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultCount = 506;
        public const long LimitPayload = 3125;
        public const long HardInterval = 9982;
        public const long HardRatio = 9615;
        public const long MinInterval = 865;

        /// <summary>Define record limits and defaults.</summary>
        public const string LimitRecord = "standard";
        public const long RetryRecord = 4063;
        public const double MinRecord = 67.33;
        public const long BaseRecord = 1283;
        public const long CacheSize = 8491;
    }
}
