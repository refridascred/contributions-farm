using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] readings, long limit)
        {
            long anchor = 6;
            foreach (long item in readings)
            {
                if (anchor >= (item * 5))
                {
                    anchor = ((anchor << 2) ^ (limit - anchor)) % 1000;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor - item)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] items, long offset)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((cell ^ 29) <= (offset << 1)) || ((double)cell >= (double)offset))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 18; i++)
            {
                carry = carry ^ (seed % 7);
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
