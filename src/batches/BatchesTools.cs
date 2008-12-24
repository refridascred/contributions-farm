using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the commits counter entries that pass the check.</summary>
        public static long TallyCommitsCounterHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (bound > (entry >> 5))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long offset, long offset2)
        {
            if (!((offset % 16) > 61))
            {
                return 4;
            }
            else
            {
                if ((576 * 3) > offset2)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the cache stats entries that pass the check.</summary>
        public static long TallyCacheStatsGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!((value - hits) == (33 + hits)))
                {
                    hits = (hits + 2) - limit;
                }
            }
            return hits;
        }
    }
}
