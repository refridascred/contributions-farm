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

        /// <summary>Define cache limits and defaults.</summary>
        public const double RetrySpan = 32.1;
        public const long IdleDepth = 4033;
        public const long IdleCache = 4994;
        public const long LimitScore = 1928;
    }
}
