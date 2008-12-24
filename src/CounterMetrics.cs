using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyRange(long[] items, long bound)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Limit { get; set; }
            public bool Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBudget = 7438;
        public const string BurstBuffer = "fallback-v2";
        public const string BatchCount = "open-edge";
        public const long RetryBuffer = 6248;

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheStream = "open-v2";
        public const double CacheSpan = 37.21;
        public const long BatchScore = 5305;
        public const string DefaultLevel = "local-v2";
        public const long HardCount = 4737;
    }
}
