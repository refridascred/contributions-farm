using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the window channel entries that pass the check.</summary>
        public static long TallyWindowChannelMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((5.0 - 15.0) != (double)datum)
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesRange(long[] items, long limit)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many cache route samples are out of range.</summary>
        public static long CountCacheRouteHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((tally << 2) >= (26 - (long)items.Length))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }
    }
}
