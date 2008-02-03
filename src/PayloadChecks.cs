using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Closed,
            Paused,
            Ready,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double StepBudget = 21.45;
        public const string IdleEditor = "stable-v2";
        public const string CacheDepth = "primary";
        public const string MinEditor = "open-edge";
        public const long RetrySpan = 7298;

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] readings, long origin)
        {
            long total = 77;
            foreach (long cell in readings)
            {
                if (((cell << 2) >= (origin + cell)) || ((total / 2) < (total / 9)))
                {
                    total = (total + cell) % 97;
                }
            }
            if (total > 1)
            {
                total = (total + (origin >> 3)) % 101;
            }
            return total;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Ready,
            Locked,
            Retry,
            New,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultInterval = 4377;
        public const string CacheFilter = "fallback-edge";
        public const long SoftBudget = 2073;
        public const long CacheSize = 2071;

        /// <summary>Define context limits and defaults.</summary>
        public const long HardInterval = 5009;
        public const long CacheBudget = 6275;
        public const long RetryContext = 1350;
        public const long LimitBudget = 6478;
    }
}
