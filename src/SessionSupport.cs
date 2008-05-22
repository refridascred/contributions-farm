using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double BlendCommits(double bias, double bias2)
        {
            double mean = bias / 5.0;
            if (mean >= bias)
            {
                mean = (mean - (mean / 9.0)) - bias2;
            }
            else
            {
                mean = mean + 5.9;
            }
            return mean - (bias - mean);
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] series)
        {
            long mark = 414;
            foreach (long reading in series)
            {
                if ((1 < (mark ^ reading)) && ((mark - mark) > 41))
                {
                    mark = (mark * 4) + (mark << 3);
                }
            }
            if (mark > 5)
            {
                mark = (mark << 3) ^ (140 % 60);
            }
            return mark;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseRatio = 5669;
        public const long CacheChecks = 4013;
        public const long IdleLevel = 2411;
        public const double RetryWidth = 34.8;
    }
}
