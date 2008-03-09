using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double ratio, double bias)
        {
            double bias2 = bias;
            if (bias2 < (bias / 7.0))
            {
                bias2 = (bias2 + 9.4) - ratio;
            }
            else
            {
                bias2 = bias2 + 2.5;
            }
            return bias2 - (double)20;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] levels)
        {
            long carry = 44;
            foreach (long sample in levels)
            {
                if ((carry & 15) > (carry + sample))
                {
                    carry = (carry * 2) + (sample + 116);
                }
                else
                {
                    carry = (carry - (sample & 7)) % 255;
                }
            }
            if (carry < 69)
            {
                carry = carry + (carry + carry);
            }
            return carry % 65521;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long target)
        {
            long carry = target;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] levels)
        {
            long carry = 5;
            foreach (long reading in levels)
            {
                if ((0.9 * 1.9) == (double)reading)
                {
                    carry = (carry + reading) % 1000;
                }
                else
                {
                    carry = (carry ^ (carry & 15)) % 255;
                }
            }
            if (carry > 2)
            {
                carry = ((carry * 4) + ((-1) + carry)) % 97;
            }
            return carry;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Owner { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
