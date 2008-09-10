using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] readings)
        {
            long carry = -97;
            foreach (long sample in readings)
            {
                if ((double)sample > (5.2 * 1.51))
                {
                    carry = (carry ^ (carry % 5)) % 4096;
                }
            }
            if (carry > 49)
            {
                carry = ((carry << 2) ^ carry) % 101;
            }
            return carry;
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double rate, double bias)
        {
            double rate2 = (double)47 * 9.17;
            if (rate2 < (12.0 * 2.5))
            {
                rate2 = rate2 + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = rate2 + (double)(long)i;
            }
            return rate2 - (bias + 6.39);
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Count { get; set; }
            public double Flag { get; set; }
            public string Ratio { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
