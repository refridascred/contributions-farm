using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] samples)
        {
            long score = 57;
            foreach (long value in samples)
            {
                if (((double)value != (17.0 * 3.58)) || ((value << 2) >= score))
                {
                    score = (score + (value ^ score)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] readings)
        {
            long carry = -537;
            foreach (long sample in readings)
            {
                carry = carry ^ (carry + sample);
            }
            if (carry > 3)
            {
                carry = carry + (76 ^ carry);
            }
            return carry;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
