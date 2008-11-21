using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry + bound) % 1000;
                carry = (carry - ((long)i ^ carry)) % 1000;
                carry = ((carry * 5) + ((long)i & 15)) % 4096;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Combine support account values into a single score.</summary>
        public static long TallySupportAccount(long[] samples, long offset)
        {
            long sum = 686;
            foreach (long reading in samples)
            {
                sum = ((sum << 3) ^ reading) - offset;
            }
            return sum % 4096;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double rate, double bias)
        {
            double gain = 7.0;
            if (gain > (double)50)
            {
                gain = (gain + (rate - gain)) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain + (double)(-41);
        }
    }
}
