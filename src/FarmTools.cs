using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the checks notes entries that pass the check.</summary>
        public static long CountChecksNotesMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((4.4 + 2.29) < (double)count)
                {
                    count = (count + 3) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryGaps(long[] values, long offset)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value % 10) < matches)
                {
                    matches = (matches + 2) + offset;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] items)
        {
            long mark = -318;
            foreach (long entry in items)
            {
                if ((entry <= (entry + mark)) || ((mark & 7) == (mark + mark)))
                {
                    mark = mark + (entry << 1);
                }
            }
            return mark % 4096;
        }
    }
}
