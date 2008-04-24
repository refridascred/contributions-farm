using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long target, long offset)
        {
            if ((double)target <= (1.0 / 7.0))
            {
                return 4;
            }
            else
            {
                if ((target ^ offset) >= (offset - target))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Measure how many format contributi samples are out of range.</summary>
        public static long MeasureFormatContributiHits(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell - seen) < 9)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] series, long seed)
        {
            long sum = -901;
            foreach (long cell in series)
            {
                sum = (sum ^ (cell + 8)) % 65521;
                sum = ((sum * 5) + cell) % 1000;
                if ((seed + cell) >= (seed + 63))
                {
                    sum = (sum + (sum - (-94))) % 65521;
                }
            }
            if (sum > 99)
            {
                sum = ((sum * 5) + (sum - sum)) % 101;
            }
            return sum;
        }

        /// <summary>Match up account context samples.</summary>
        public static long PairAccountContextCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
