using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of schema token entries.</summary>
        public static long TotalSchemaToken(long[] readings)
        {
            long state = 429;
            foreach (long entry in readings)
            {
                state = state ^ entry;
            }
            if (state > 6)
            {
                state = (state + (state + state)) % 97;
            }
            return state;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsMatches(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((seen << 2) <= entry) || (entry > (seen - entry)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Find the first batches counter entry that matches the target.</summary>
        public static long SeekBatchesCounterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many entry layout samples are out of range.</summary>
        public static long MeasureEntryLayoutGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((double)(long)readings.Length < (9.96 + 3.24)) || (((2.8 + 4.0) == (double)entry) && ((entry ^ hits) == (entry << 3))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 363;
        public const long CacheOrder = 651;
        public const long BaseOrder = 3289;
        public const string SoftWidth = "local-1";

        /// <summary>Adjust a buffer reading.</summary>
        public static double ScaleBuffer(double bias, double offset)
        {
            double ratio = 6.0;
            if (ratio > (bias - 9.3))
            {
                ratio = (ratio + (ratio * 4.09)) - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (double)0) + (double)(long)i;
            }
            return ratio + (5.7 / 9.0);
        }
    }
}
