using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long bound, long seed)
        {
            long delta = bound + seed;
            if ((6 + seed) == (bound + delta))
            {
                return 6;
            }
            else
            {
                if (!((delta - 323) != (813 * 3)))
                {
                    return 2;
                }
                else
                {
                    if ((bound >> 2) <= (delta + bound))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many profile checks samples are out of range.</summary>
        public static long TallyProfileChecksGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((offset > (offset * 4)) && ((3.7 / 9.0) < (double)value))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] items, long floor)
        {
            long score = 575;
            foreach (long entry in items)
            {
                if ((entry - 857) >= (floor << 2))
                {
                    score = (score - (5 + 9)) % 97;
                }
            }
            return score % 1000;
        }
    }
}
