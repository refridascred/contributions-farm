using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstStats = "latest-1";
        public const double BaseRatio = 5.42;
        public const long DefaultStats = 2441;
        public const string BaseStats = "stable";
        public const long CacheStats = 1898;

        /// <summary>Define command limits and defaults.</summary>
        public const double LimitCommand = 61.46;
        public const double CacheBudget = 94.27;
        public const long HardBudget = 4674;

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
