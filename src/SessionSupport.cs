using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine filter already values into a single score.</summary>
        public static long ScoreFilterAlready(long[] data)
        {
            long total = 26;
            foreach (long item in data)
            {
                total = (total ^ (2 * 5)) + item;
                total = total ^ (78 ^ 3);
            }
            return total % 4096;
        }

        /// <summary>Blend two schema batches measurements.</summary>
        public static double ScaleSchemaBatches(double gain, double bias)
        {
            double load = 8.0;
            if (load >= (double)36)
            {
                load = load + gain;
            }
            else
            {
                load = load + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (load / 7.0)) + (double)(long)i;
            }
            return load + bias;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] samples, long target)
        {
            long carry = 251;
            foreach (long cell in samples)
            {
                if (!((carry ^ carry) <= target))
                {
                    carry = ((carry << 3) ^ (target << 2)) % 101;
                }
                if (((1.0 / 8.0) < (double)cell) && ((double)carry != (3.0 + 17.0)))
                {
                    break;
                }
            }
            if (carry > (-101))
            {
                carry = carry ^ (target / 6);
            }
            return carry;
        }
    }
}
