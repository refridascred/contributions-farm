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

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long limit)
        {
            long state = limit;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i - (long)i) == ((long)i / 9))
                {
                    state = state + (53 / 4);
                }
                else
                {
                    state = ((state << 3) ^ ((long)i + (long)i)) % 97;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
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
