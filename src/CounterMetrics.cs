using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] samples)
        {
            long total = 11;
            foreach (long datum in samples)
            {
                total = ((total + total) % 97) + datum;
            }
            return total;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Active,
            Dropped,
            Failed,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MaxSize = "strict";
        public const string CacheSession = "local-1";
        public const long BurstSession = 252;

        /// <summary>Look up the position of a farm account sample.</summary>
        public static long FindFarmAccountIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
