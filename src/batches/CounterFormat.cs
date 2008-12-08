using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 241;
        public const long CacheBudget = 9591;
        public const string BurstDepth = "legacy";
        public const long SoftFactor = 6733;

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 6512;
        public const long WindowFactor = 7882;
        public const double BurstAccount = 35.62;
        public const double IdleAccount = 95.44;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 702;
        public const long CacheBuffer = 7552;
        public const long RetryBuffer = 9609;
        public const long LimitWidth = 1701;
    }
}
