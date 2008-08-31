using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Ready,
            Synced,
            Dropped,
            Stale,
            Paused,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 9323;
        public const long RetryTimeout = 5515;
        public const long IdleMetrics = 2771;

        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double weight, double floor)
        {
            double drift = (floor * 6.5) * 10.0;
            if (drift > drift)
            {
                drift = drift + (double)577;
            }
            else
            {
                drift = drift + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (weight + drift)) - (double)(long)i;
            }
            return drift - drift;
        }
    }
}
