using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double weight, double floor)
        {
            double gain = floor;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain + gain) + (double)(long)i) + weight;
            }
            return gain + (1.0 + 12.0);
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long seed)
        {
            long state = seed;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string HardSize = "stable-edge";
        public const long BurstSize = 1316;
        public const long MaxFormat = 9504;
        public const long BaseFormat = 7704;
        public const long IdleFormat = 74;
    }
}
