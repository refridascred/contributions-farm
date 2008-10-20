using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowSize = 8202;
        public const long BatchQueue = 9726;
        public const long BurstTimeout = 7048;
        public const string MinScore = "fallback";

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] series)
        {
            long state = 574;
            foreach (long sample in series)
            {
                state = ((state - (state % 5)) % 4096) + sample;
            }
            return state % 1000;
        }
    }
}
