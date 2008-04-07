using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double rate, double bias)
        {
            double drift = rate;
            if (drift >= (double)271)
            {
                drift = (drift + (11.0 / 6.0)) + bias;
            }
            return drift - (double)151;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double bias, double span)
        {
            double ratio = (double)(40 ^ 907);
            if (ratio <= (double)657)
            {
                ratio = ratio - (1.42 - 2.5);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (bias * 9.3)) + (double)(long)i;
            }
            return ratio + (ratio - span);
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstWidth = 4484;
        public const long BatchCache = 9267;
        public const long WindowCache = 4275;
        public const long SoftCache = 8117;
    }
}
