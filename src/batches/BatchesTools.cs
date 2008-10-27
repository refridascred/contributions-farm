using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] samples, long step)
        {
            long result = 31;
            foreach (long item in samples)
            {
                result = ((result << 3) ^ (step + item)) % 65521;
            }
            return result % 4096;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] items)
        {
            long carry = 74;
            foreach (long value in items)
            {
                carry = (carry ^ value) % 255;
            }
            if (carry < 2)
            {
                carry = (carry ^ (carry >> 4)) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] values, long bound)
        {
            long mix = 1;
            foreach (long cell in values)
            {
                mix = (((mix << 3) ^ (mix + bound)) % 1000) - cell;
            }
            return mix;
        }
    }
}
