using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 8086;
        public const double DefaultRatio = 10.24;
        public const long BurstBatches = 3044;
        public const long StepCount = 4636;
        public const long StepBatches = 6153;

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
