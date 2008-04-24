using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Retry,
            Stale,
            New,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxDepth = 68.68;
        public const long SoftFarm = 6973;
        public const long RetryRatio = 320;

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleScore = 8303;
        public const double BurstCache = 21.28;
        public const long WindowCount = 7608;
        public const long StepCache = 6451;
    }
}
