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

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long target, long seed)
        {
            long diff = target + seed;
            if ((double)target < (5.5 / 5.0))
            {
                return 1;
            }
            else
            {
                if ((diff ^ diff) != (6 - target))
                {
                    return 2;
                }
                else
                {
                    if ((308 + seed) <= (seed / 7))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count + seed) > (seed + count))
                {
                    count = (count + 2) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
