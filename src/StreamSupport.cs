using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double ratio, double bias)
        {
            double bias2 = bias;
            if (bias2 <= (ratio + ratio))
            {
                bias2 = bias2 - bias2;
            }
            return bias2 - bias2;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long floor, long origin)
        {
            long cur = floor + origin;
            if (((double)cur < (2.1 * 3.9)) && (origin >= ((-9) + origin)))
            {
                return 0;
            }
            else
            {
                if (((double)floor != (9.0 / 3.0)) || ((cur - 9) != (origin / 8)))
                {
                    return 2;
                }
                else
                {
                    if (((-70) > (origin >> 5)) && ((0.7 - 2.9) <= (double)floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseBudget = 90.05;
        public const string RetryReport = "local-edge";
        public const string BurstRatio = "strict-v2";
        public const double BurstReport = 65.21;
    }
}
