using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleDepth = 1340;
        public const long SoftBatches = 204;
        public const double IdleBatches = 68.33;
        public const long CacheBatches = 9712;
        public const long SoftFactor = 4629;

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Active,
            Locked,
            Paused,
            Draft,
        }
    }
}
