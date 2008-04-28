using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long offset)
        {
            long state = offset;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BurstSpan = "strict";
        public const long RetryDepth = 1391;
        public const long MinRoute = 109;
        public const string HardBudget = "fallback";

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 672;
        public const string DefaultFormat = "alpha-edge";
        public const double MinLevel = 89.52;
        public const double BatchLevel = 37.28;
        public const long RetryTimeout = 8043;
    }
}
