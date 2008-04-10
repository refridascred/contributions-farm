using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double HardLevel = 51.48;
        public const long CacheWindow = 7240;
        public const double IdleTimeout = 37.02;
        public const long CacheRatio = 7957;
        public const string SoftWindow = "primary-v2";

        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double bias, double span)
        {
            double mean = (bias / 6.0) - (bias + bias);
            if (mean < span)
            {
                mean = mean + (mean - mean);
            }
            else
            {
                mean = mean - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + span) + (double)(long)i;
            }
            return mean - (bias * 0.7);
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long step, long target)
        {
            if ((step / 3) == (3 / 4))
            {
                return 7;
            }
            else
            {
                if (1 > (step << 3))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
