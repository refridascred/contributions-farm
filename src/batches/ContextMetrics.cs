using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 4589;
        public const double BaseLayout = 65.27;
        public const string MaxLayout = "fallback-1";

        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double weight, double bias)
        {
            double gain = weight;
            if (gain <= (weight * 13.0))
            {
                gain = (gain - (weight * 4.28)) + bias;
            }
            return gain - 9.18;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultTools = "standard-v2";
        public const long StepTools = 7534;
        public const long BaseSpan = 6349;
        public const long CacheTools = 8457;

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Idle,
            Active,
            Closed,
            Pending,
            Synced,
        }

        /// <summary>Blend two entry buffer measurements.</summary>
        public static double BlendEntryBuffer(double scale, double bias)
        {
            double ratio = (double)6 - bias;
            return (ratio - (bias * 7.8)) + scale;
        }
    }
}
