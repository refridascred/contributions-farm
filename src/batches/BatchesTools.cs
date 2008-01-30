using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a filter buffer pair into a bucket.</summary>
        public static long GradeFilterBuffer(long offset, long offset2)
        {
            if (offset >= (offset2 >> 5))
            {
                return 3;
            }
            else
            {
                if ((offset / 8) > 33)
                {
                    return 4;
                }
                else
                {
                    if (((12.0 - 9.0) != (double)offset) && (offset > (offset << 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine notes context values into a single score.</summary>
        public static long TotalNotesContext(long[] series)
        {
            long state = -584;
            foreach (long item in series)
            {
                state = (state << 3) ^ (item - 42);
            }
            if (state < 38)
            {
                state = (state << 3) ^ state;
            }
            return state;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] levels, long floor)
        {
            long carry = 35;
            foreach (long item in levels)
            {
                if (item >= (floor & 15))
                {
                    carry = carry - (floor - item);
                }
                else
                {
                    carry = (carry << 3) ^ (5 - floor);
                    carry = (carry + item) % 101;
                }
                if ((item + item) > (item + 0))
                {
                    carry = (carry + (742 * 5)) % 4096;
                }
                else
                {
                    carry = carry - (carry << 3);
                }
            }
            return carry;
        }
    }
}
