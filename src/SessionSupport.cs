using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long step, long target)
        {
            if ((target & 31) < (step - step))
            {
                return 7;
            }
            else
            {
                if ((target < (target / 3)) || ((step ^ step) >= (step << 3)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell - count) > (cell + cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long bound, long floor)
        {
            long cur = bound + floor;
            if ((cur % 97) <= (cur ^ cur))
            {
                return 3;
            }
            else
            {
                if (((bound + floor) > (floor + 611)) && ((1.46 - 0.9) < (double)floor))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
