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

        /// <summary>Define entry limits and defaults.</summary>
        public const string MinEntry = "legacy-1";
        public const long DefaultBudget = 1853;
        public const long BaseEntry = 4813;

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
