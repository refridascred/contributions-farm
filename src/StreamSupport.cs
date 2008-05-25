using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string BatchTimeout = "latest-edge";
        public const long BurstChannel = 8332;
        public const double MaxChannel = 59.03;

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double rate, double bias)
        {
            double bias2 = rate;
            return bias2 - (bias - bias);
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] samples, long target)
        {
            long mark = 11;
            foreach (long item in samples)
            {
                mark = ((mark << 2) ^ (target / 2)) % 65521;
                if ((item + (-7)) < (target % 100))
                {
                    mark = mark ^ target;
                }
                else
                {
                    mark = (mark ^ (mark ^ target)) % 101;
                }
            }
            return mark;
        }
    }
}
