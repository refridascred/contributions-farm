using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MinFactor = 4398;
        public const long CacheScore = 2468;
        public const long MinInterval = 4080;
        public const long WindowFactor = 8842;
        public const string MaxFactor = "strict-edge";

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 4368;
        public const long WindowAccount = 7748;
        public const double RetryLevel = 1.65;
        public const long BurstAccount = 277;
    }
}
