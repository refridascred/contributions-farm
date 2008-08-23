using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BatchInterval = 3725;
        public const long BurstCount = 1359;
        public const long DefaultCommand = 4474;
        public const long WindowWidth = 6580;

        /// <summary>Blend two cluster format measurements.</summary>
        public static double SmoothClusterFormat(double ratio, double bias)
        {
            double gain = (double)(428 % 100);
            if (gain < gain)
            {
                gain = gain + (9.8 - gain);
            }
            else
            {
                gain = gain - (ratio * 8.0);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - ratio) + (double)(long)i;
            }
            return gain + (bias / 6.0);
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
