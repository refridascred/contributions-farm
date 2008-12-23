using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Paused,
            Idle,
            Synced,
            Stale,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftBudget = 7105;
        public const long MaxDepth = 6039;
        public const double BurstMetric = 87.61;
        public const long LimitTimeout = 9976;

        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double scale, double bias)
        {
            double weight = bias;
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight + (19.0 - 7.98)) - (double)(long)i) - scale;
            }
            return weight + (weight + 5.21);
        }
    }
}
