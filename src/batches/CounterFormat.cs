using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long HardBudget = 3157;
        public const long SoftWidth = 1386;
        public const string MaxLevel = "standard-1";
        public const string LimitTimeout = "primary-edge";

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinSchema = 73.53;
        public const long CacheDepth = 3887;
        public const long BaseSchema = 4146;
        public const long BatchScore = 6028;
        public const long DefaultWidth = 8682;

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Mode { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public long Label { get; set; }
        }
    }
}
