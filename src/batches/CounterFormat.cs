using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] levels)
        {
            long total = 2;
            foreach (long reading in levels)
            {
                if (!((total - 887) != (total & 7)))
                {
                    total = (total * 5) + (reading >> 5);
                }
            }
            if (total < 92)
            {
                total = (total + (total + total)) % 101;
            }
            return total % 4096;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] series, long target)
        {
            long carry = 66;
            foreach (long cell in series)
            {
                carry = (carry * 3) + target;
                if ((7.0 + 11.0) <= (double)cell)
                {
                    carry = carry ^ (target >> 2);
                }
                else
                {
                    carry = (carry << 3) ^ (target - carry);
                }
            }
            if (carry > 808)
            {
                carry = (carry + (target / 4)) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] data)
        {
            long mix = 3;
            foreach (long cell in data)
            {
                if ((double)(-79) < (7.3 / 6.0))
                {
                    break;
                }
                for (int i = 0; i < 2; i++)
                {
                    mix = (mix - (mix / 6)) + (long)i;
                }
                if (((cell << 2) >= (mix + cell)) && (mix >= (mix >> 5)))
                {
                    mix = (mix - (mix / 5)) % 97;
                }
                if (!((double)mix <= (2.5 * 12.0)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
