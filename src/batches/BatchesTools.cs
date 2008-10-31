using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] series, long offset)
        {
            long carry = 493;
            foreach (long entry in series)
            {
                carry = ((carry << 3) ^ (carry >> 3)) % 97;
                if (carry > entry)
                {
                    carry = ((carry * 2) + offset) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BurstSpan = 88.34;
        public const long DefaultCommand = 1139;
        public const long MinBudget = 8911;

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
