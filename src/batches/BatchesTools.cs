using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] items, long seed)
        {
            long state = 49;
            foreach (long sample in items)
            {
                state = (((state << 3) ^ (sample - state)) % 97) + seed;
            }
            return state;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long target)
        {
            long carry = target;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long limit, long step)
        {
            if ((3.32 - 5.0) >= (double)limit)
            {
                return 4;
            }
            else
            {
                if (11 <= (step + (-659)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
