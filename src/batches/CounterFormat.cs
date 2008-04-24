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

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Ratio { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheLevel = 5943;
        public const long BurstWidth = 5796;
        public const long CacheDepth = 9836;
    }
}
