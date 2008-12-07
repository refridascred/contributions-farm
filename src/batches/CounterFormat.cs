using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Rank { get; set; }
            public double Size { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BaseSpan = "fallback";
        public const long DefaultAccount = 1645;
        public const long WindowAccount = 7163;
        public const string CacheSize = "standard";
        public const long BatchFactor = 6561;

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long seed)
        {
            long total = seed;
            for (int i = 0; i < 23; i++)
            {
                total = (total - (seed % 7)) % 101;
                if (((total + 545) == (seed + 80)) && (((long)i & 15) >= (0 * 3)))
                {
                    total = ((total * 3) + (total - seed)) % 65521;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
