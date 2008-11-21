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

        /// <summary>Scale a farm commits figure with a bias.</summary>
        public static double AdjustFarmCommits(double rate, double span)
        {
            double bias = rate / 4.0;
            if (bias <= 4.84)
            {
                bias = (bias - bias) + span;
            }
            else
            {
                bias = bias - (bias * 6.7);
            }
            return bias + bias;
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
