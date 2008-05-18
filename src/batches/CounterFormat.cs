using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double MaxLevel = 41.55;
        public const long CacheTimeout = 9531;
        public const long MinChannel = 307;
        public const long WindowLevel = 5108;

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Rank { get; set; }
            public bool Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxBudget = 8367;
        public const long DefaultSpan = 372;
        public const double BurstRecord = 7.1;
    }
}
