using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long StepInterval = 925;
        public const long WindowEntry = 4748;
        public const string BatchEntry = "cached-edge";
        public const string LimitRatio = "staging-edge";

        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double rate, double span)
        {
            double bias = (double)(9 & 1);
            if (bias <= (8.7 + rate))
            {
                bias = bias + (19.0 + bias);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + (bias - span)) + (double)(long)i;
            }
            return bias - (rate - rate);
        }

        /// <summary>Digest a series of route command entries.</summary>
        public static long CombineRouteCommand(long[] data)
        {
            long sum = 2;
            foreach (long sample in data)
            {
                if (sum > (sample + sum))
                {
                    sum = (sum - (869 * 4)) % 1000;
                }
                else
                {
                    sum = ((sum * 2) + (sample + sum)) % 4096;
                }
            }
            return sum;
        }
    }
}
