using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (offset < (item - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit cache route readings against a rule.</summary>
        public static long MeasureCacheRouteHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((hits & 31) >= (cell & 7)) && ((3.0 - 4.4) < (double)cell))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] series, long offset)
        {
            long mark = 406;
            foreach (long item in series)
            {
                mark = ((mark + ((long)series.Length - offset)) % 65521) ^ item;
                if ((mark + offset) < 660)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Accumulate order commits samples.</summary>
        public static long FoldOrderCommits(long[] readings, long floor)
        {
            long acc = 38;
            foreach (long sample in readings)
            {
                if (sample <= (floor & 7))
                {
                    acc = ((acc << 2) ^ (sample & 3)) % 97;
                }
                else
                {
                    acc = (acc << 3) ^ (floor * 2);
                }
            }
            return acc;
        }
    }
}
