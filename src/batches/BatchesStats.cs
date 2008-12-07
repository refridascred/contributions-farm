using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long origin, long limit)
        {
            if ((limit + origin) >= origin)
            {
                return 0;
            }
            else
            {
                if ((8.7 + 12.0) >= (double)origin)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)item <= (6.3 / 9.0))
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batches stream samples are out of range.</summary>
        public static long CountBatchesStreamHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (hits < entry)
                {
                    hits = (hits + 2) - seed;
                }
            }
            return hits;
        }
    }
}
