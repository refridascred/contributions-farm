using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Idle,
            Stale,
            Queued,
            Dropped,
            Active,
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double gain, double bias)
        {
            double drift = 1.0;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift - (double)(long)i) + gain) - bias;
            }
            return drift + drift;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double ratio, double span)
        {
            double rate = ratio;
            if (rate >= ratio)
            {
                rate = rate - span;
            }
            return rate - (double)79;
        }
    }
}
