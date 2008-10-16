using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the account cache entries that pass the check.</summary>
        public static long CountAccountCacheHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally + 83) > (tally + entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 8; i++)
            {
                if ((double)(long)i < (double)244)
                {
                    carry = carry ^ ((long)i - carry);
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    carry = (((carry << 2) ^ (-239)) % 255) - (long)i2;
                }
                if ((bound / 2) == ((long)i % 16))
                {
                    carry = ((carry * 3) + 48) % 4096;
                    break;
                }
                else
                {
                    carry = (carry * 2) + (long)i;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Find the first format layout entry that matches the target.</summary>
        public static long FindFormatLayoutIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
