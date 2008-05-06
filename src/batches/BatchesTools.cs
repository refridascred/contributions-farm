using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] series)
        {
            long carry = 1;
            foreach (long reading in series)
            {
                if (((68 - (long)series.Length) >= 351) || ((11.0 / 9.0) != (double)(long)series.Length))
                {
                    carry = ((carry + (carry + carry)) % 65521) + reading;
                }
                else
                {
                    carry = (carry - (86 & 31)) % 255;
                }
            }
            return carry;
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
