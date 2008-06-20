using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every batches farm entry stays within the limit.</summary>
        public static bool ValidateBatchesFarmBounds(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
