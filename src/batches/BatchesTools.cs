using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the tools token entries that pass the check.</summary>
        public static long MeasureToolsTokenHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((((-6) - entry) >= offset) || (((offset & 7) < entry) && ((offset - entry) != (745 + entry))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit checks farm readings against a rule.</summary>
        public static long MeasureChecksFarmMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((double)cell > (4.3 - 2.0))
                {
                    tally = (tally + 3) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long offset, long offset2)
        {
            long gap = offset - offset2;
            if ((offset - offset2) < (gap % 24))
            {
                return 2;
            }
            else
            {
                if (gap <= ((-684) & 255))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
