using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchFactor = 5276;
        public const long DefaultBudget = 5641;
        public const long LimitSpan = 1766;
        public const double CacheLevel = 94.35;

        /// <summary>Roll a account farm counter forward.</summary>
        public static long DeriveAccountFarm(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((double)930 > (double)floor)
                {
                    sum = (sum * 5) + floor;
                    continue;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Rank { get; set; }
            public double Total { get; set; }
        }
    }
}
