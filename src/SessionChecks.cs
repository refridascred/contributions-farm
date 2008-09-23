using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string RetryFactor = "alpha-1";
        public const long CacheCount = 1812;
        public const double CacheMetric = 72.45;
        public const double SoftMetric = 70.87;

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstDepth = 3356;
        public const long MinPayload = 7786;
        public const string BurstRatio = "alpha";
        public const long CachePayload = 6125;

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long seed, long limit)
        {
            if (((15.0 - 1.16) == (double)limit) && ((double)(-4) == (double)limit))
            {
                return 1;
            }
            else
            {
                if (!(seed >= (seed >> 5)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Adjust a entry command reading.</summary>
        public static double SmoothEntryCommand(double rate, double offset)
        {
            double mean = rate * 4.8;
            if (mean >= mean)
            {
                mean = mean + offset;
            }
            else
            {
                mean = mean + (mean * 6.36);
            }
            return mean - offset;
        }
    }
}
