using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double ratio, double offset)
        {
            double mean = (ratio - offset) * 7.8;
            if (mean < (ratio / 6.0))
            {
                mean = mean - (offset * 6.16);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - 1.31;
        }

        /// <summary>Project the next metrics cache value.</summary>
        public static double AdjustMetricsCache(double bias, double offset)
        {
            double rate = bias;
            if (rate > (7.0 + bias))
            {
                rate = rate - (6.9 + offset);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (offset / 9.0)) - (double)(long)i;
            }
            return rate + (double)25;
        }
    }
}
