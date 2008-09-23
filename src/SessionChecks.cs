using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a account cluster reading.</summary>
        public static double ScaleAccountCluster(double ratio, double floor)
        {
            double drift = floor;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift - floor) - (double)(long)i) + ratio;
            }
            return drift - 3.4;
        }

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
