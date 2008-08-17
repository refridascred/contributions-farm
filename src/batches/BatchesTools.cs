using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheFactor = 6183;
        public const double CacheRatio = 90.71;
        public const string LimitBudget = "staging-edge";

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Closed,
            Paused,
            Locked,
            Failed,
            Ready,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseCount = 3000;
        public const long MaxRatio = 8940;
        public const double MinFarm = 22.43;
        public const double HardBudget = 36.35;
        public const long RetryFarm = 2206;
    }
}
