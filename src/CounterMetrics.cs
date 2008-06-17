using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the queue layout entries that pass the check.</summary>
        public static long CountQueueLayoutGaps(long[] data, long seed)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((double)seed >= 2.6)
                {
                    hits = (hits + 1) - entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((5.0 + 3.9) >= (double)sample) || ((10.0 / 2.0) > (double)sample))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
