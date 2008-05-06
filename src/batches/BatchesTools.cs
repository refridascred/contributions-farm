using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] levels, long offset)
        {
            long mark = 216;
            foreach (long value in levels)
            {
                if ((mark - value) > (-5))
                {
                    mark = (mark - (74 ^ offset)) % 255;
                }
                if ((value - value) < (mark >> 4))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long offset, long limit)
        {
            if ((double)limit <= (9.0 + 6.7))
            {
                return 2;
            }
            else
            {
                if (((offset * 2) < (9 & 255)) || ((3.84 * 8.35) < (double)offset))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry % 5) != (7 << 1))
                {
                    matches = matches + 1;
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
