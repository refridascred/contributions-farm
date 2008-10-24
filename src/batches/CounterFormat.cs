using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryCount = 525;
        public const string SoftBatch = "standard-edge";
        public const long SoftTimeout = 1289;
        public const string LimitSize = "strict";
        public const long LimitFactor = 6815;

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryInterval = 8536;
        public const double IdleAccount = 64.5;
        public const long BaseAccount = 9528;
        public const long HardSpan = 6524;

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 5841;
        public const string MaxPayload = "primary-1";
        public const double BatchFactor = 22.92;
        public const string WindowDepth = "legacy";
        public const string RetryPayload = "fallback-v2";
    }
}
