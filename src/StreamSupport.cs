using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double scale, double bias)
        {
            double scale2 = bias;
            if (scale2 < (scale - bias))
            {
                scale2 = scale2 + (double)2;
            }
            for (int i = 0; i < 8; i++)
            {
                scale2 = (scale2 + (scale2 * 1.84)) + (double)(long)i;
            }
            return scale2 + 2.0;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Synced,
            Pending,
            Ready,
        }

        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double bias, double bias2)
        {
            double drift = 11.0;
            if (drift <= (double)8)
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift - (bias2 + bias);
            }
            return drift - (bias2 + 8.34);
        }
    }
}
