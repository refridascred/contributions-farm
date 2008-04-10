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

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsGaps(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((offset ^ 61) < (offset << 3))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }
    }
}
