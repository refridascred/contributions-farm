using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Retry,
            New,
            Synced,
            Queued,
            Paused,
        }

        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double gain, double floor)
        {
            double rate = (double)((-59) + 3);
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate - (gain / 7.0)) - (double)(long)i) + floor;
            }
            return rate + (double)(-571);
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double bias, double floor)
        {
            double scale = bias;
            if (scale <= (double)784)
            {
                scale = (scale + bias) + floor;
            }
            else
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - (bias * 1.06);
        }
    }
}
