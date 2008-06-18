using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (tally < (tally ^ entry))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit stream profile readings against a rule.</summary>
        public static long MeasureStreamProfileMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (3.5 < (double)seen)
                {
                    seen = (seen + 1) - value;
                }
            }
            return seen;
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
