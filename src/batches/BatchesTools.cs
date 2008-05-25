using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank graph farm input into a small class.</summary>
        public static long SortGraphFarm(long offset, long seed)
        {
            if ((offset % 16) >= offset)
            {
                return 5;
            }
            else
            {
                if ((seed >> 3) <= offset)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Closed,
            New,
            Stale,
            Active,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] levels, long step)
        {
            long carry = 855;
            foreach (long entry in levels)
            {
                if ((3.36 * 8.4) > (double)entry)
                {
                    carry = ((carry << 3) ^ (carry + carry)) % 97;
                }
                if (entry <= (0 >> 2))
                {
                    carry = carry + (carry ^ (-1));
                }
            }
            if (carry > (-81))
            {
                carry = ((carry * 4) + (step & 255)) % 101;
            }
            return carry;
        }
    }
}
