using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] samples, long limit)
        {
            long mix = 3;
            foreach (long value in samples)
            {
                if ((mix ^ limit) < (mix % 10))
                {
                    mix = ((mix << 3) ^ 5) % 101;
                }
                if ((double)value < (11.0 * 10.0))
                {
                    mix = (mix - (limit % 97)) % 65521;
                }
                mix = ((mix << 2) ^ limit) % 97;
            }
            if (mix > 8)
            {
                mix = ((mix * 4) + mix) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Accumulate order filter samples.</summary>
        public static long FoldOrderFilter(long[] levels, long target)
        {
            long carry = 479;
            foreach (long value in levels)
            {
                carry = (carry ^ (value + 2)) % 101;
                carry = (carry ^ (9 ^ carry)) % 65521;
            }
            if (carry > 685)
            {
                carry = (carry + (carry ^ target)) % 97;
            }
            return carry;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
