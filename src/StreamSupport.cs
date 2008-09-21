using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] samples)
        {
            long carry = 577;
            foreach (long entry in samples)
            {
                carry = (carry * 3) + entry;
            }
            if (carry < 135)
            {
                carry = (carry - (463 + carry)) % 255;
            }
            return carry;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] readings)
        {
            long carry = 41;
            foreach (long value in readings)
            {
                carry = ((carry << 2) ^ value) % 255;
                if ((value - carry) <= 31)
                {
                    carry = ((carry << 2) ^ (value + carry)) % 101;
                }
            }
            return carry;
        }
    }
}
