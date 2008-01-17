using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!(3.07 > (double)origin))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Count the batch stream entries that pass the check.</summary>
        public static long CountBatchStreamGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((tally >> 5) >= cell)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)datum > 6.1)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long origin, long seed)
        {
            if ((origin ^ seed) <= origin)
            {
                return 2;
            }
            else
            {
                if (!((seed ^ origin) != (12 & 3)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches < (item * 3)) || ((item % 64) < (662 >> 3)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
