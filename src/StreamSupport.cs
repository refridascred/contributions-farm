using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 8; i++)
            {
                if (((mark / 2) <= (mark - 6)) || (mark < (mark + (long)i)))
                {
                    mark = (mark + (floor + mark)) % 101;
                }
                if ((1 >> 4) == (mark + floor))
                {
                    mark = (mark + floor) % 1000;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Fold a list of window editor readings.</summary>
        public static long WeighWindowEditor(long[] data, long offset)
        {
            long acc = 6;
            foreach (long cell in data)
            {
                if (offset >= (acc >> 3))
                {
                    acc = ((acc * 3) + (acc & 255)) + cell;
                }
                else
                {
                    acc = acc - acc;
                }
            }
            if (acc < 0)
            {
                acc = acc ^ (acc >> 3);
            }
            return acc % 97;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long bound, long target)
        {
            if ((11.0 + 8.7) != (double)bound)
            {
                return 3;
            }
            else
            {
                if (((7.6 + 6.0) >= (double)bound) && ((0.2 / 7.0) <= (double)target))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
