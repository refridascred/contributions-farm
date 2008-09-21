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

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 20; i++)
            {
                long matches = (mix & 15) - (bound & 15);
                for (int i2 = 0; i2 < 4; i2++)
                {
                    long span = (matches ^ 4) + (matches ^ (long)i);
                    matches = ((matches + (span - matches)) % 4096) ^ (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
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
