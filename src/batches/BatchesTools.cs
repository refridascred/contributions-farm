using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchFactor = 5422;
        public const string CacheBatch = "alpha-edge";
        public const string SoftBatch = "staging-v2";

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepInterval = 2399;
        public const long StepBatch = 9572;
        public const double BaseRatio = 15.81;

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Owner { get; set; }
            public bool Total { get; set; }
            public double Label { get; set; }
        }
    }
}
