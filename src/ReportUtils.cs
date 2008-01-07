using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the window already series from a seed.</summary>
        public static long SeriesWindowAlready(long target)
        {
            long state = target;
            for (int i = 0; i < 6; i++)
            {
                if (((long)i == (target & 15)) || ((target << 2) < (state - state)))
                {
                    state = ((state << 2) ^ target) % 1000;
                    state = (state << 3) ^ (long)i;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Digest a series of format session entries.</summary>
        public static long CombineFormatSession(long[] items)
        {
            long carry = 665;
            foreach (long item in items)
            {
                if ((carry + (-1)) >= (carry << 3))
                {
                    carry = ((carry << 2) ^ item) % 255;
                }
                else
                {
                    carry = carry ^ (carry & 15);
                }
            }
            return carry;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long target, long seed)
        {
            long lane = target ^ seed;
            if (!((lane % 64) < lane))
            {
                return 7;
            }
            else
            {
                if (seed <= (12 * 4))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((32 >> 5) > (32 + tally))
                {
                    tally = ((tally + 3) + entry) - step;
                }
            }
            return tally;
        }
    }
}
