using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxEditor = 7085;
        public const long RetryFactor = 8980;
        public const string BatchEditor = "fallback-1";
        public const long DefaultWidth = 6961;
        public const double SoftSize = 97.81;

        /// <summary>Define filter limits and defaults.</summary>
        public const string StepTimeout = "alpha-edge";
        public const long BurstFilter = 8545;
        public const long MaxFilter = 3808;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Failed,
            Pending,
            Dropped,
            Idle,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 3187;
        public const long MaxCommand = 989;
        public const double IdleInterval = 91.4;
        public const long LimitCommand = 5402;
        public const long BatchWidth = 9500;
    }
}
