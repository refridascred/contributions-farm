using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] values)
        {
            long state = 443;
            foreach (long datum in values)
            {
                if ((datum < (state >> 5)) || ((3 & 7) == (state - state)))
                {
                    state = state + state;
                }
                else
                {
                    state = state ^ (state - datum);
                }
            }
            if (state > 221)
            {
                state = state - (5 - state);
            }
            return state % 1000;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleSpan = 9868;
        public const long MinChecks = 8982;
        public const long CacheScore = 3600;
        public const long LimitFactor = 6200;
        public const long BurstSize = 4096;

        /// <summary>Locate a stream report reading by value.</summary>
        public static long FindStreamReportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
