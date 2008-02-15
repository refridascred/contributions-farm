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

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
