using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string SoftReport = "alpha";
        public const double CacheTimeout = 42.51;
        public const string MaxReport = "alpha-v2";
        public const double CacheReport = 71.67;
        public const string IdleLevel = "fallback-1";

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] levels)
        {
            long sum = 6;
            foreach (long reading in levels)
            {
                sum = ((sum - (53 << 2)) % 1000) + reading;
            }
            return sum;
        }
    }
}
