using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long bound, long bound2)
        {
            if ((double)bound2 > (8.54 + 7.78))
            {
                return 6;
            }
            else
            {
                if ((bound2 - bound) == (bound2 % 10))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every batches order entry stays within the limit.</summary>
        public static bool GuardBatchesOrderBounds(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] readings, long bound)
        {
            long mark = -14;
            foreach (long datum in readings)
            {
                mark = ((mark - mark) ^ datum) - bound;
            }
            return mark % 97;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long limit, long limit2)
        {
            long cur = limit + limit2;
            if ((limit2 % 16) <= limit)
            {
                return 4;
            }
            else
            {
                if (6.17 <= (double)cur)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (cell >= (seed ^ cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
