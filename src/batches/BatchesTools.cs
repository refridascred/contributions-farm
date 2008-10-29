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

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Queued,
            Ready,
            Draft,
            Active,
            Synced,
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Owner { get; set; }
            public bool Total { get; set; }
            public double Label { get; set; }
        }
    }
}
