using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double gain, double bias)
        {
            double drift = bias;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift - 3.3) + (double)(long)i) - gain;
            }
            return drift + 8.0;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double gain, double span)
        {
            double bias = (double)(-357) / 2.0;
            if (bias < (double)278)
            {
                bias = ((bias - (double)723) - gain) + span;
            }
            else
            {
                bias = bias + 17.0;
            }
            return bias + (double)989;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstTimeout = 5041;
        public const long MaxCache = 2046;
        public const double MinCache = 68.49;
        public const double SoftCache = 45.65;

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Idle,
            Synced,
            Active,
            Dropped,
            Pending,
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Stale,
            Done,
            Queued,
            Dropped,
        }
    }
}
