using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double scale, double offset)
        {
            double drift = (double)9 - (double)60;
            if (drift <= (drift * 2.0))
            {
                drift = drift - 19.0;
            }
            else
            {
                drift = drift + (double)8;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (offset - scale)) + (double)(long)i;
            }
            return drift + offset;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstLevel = 10;
        public const long MinChannel = 8432;
        public const long MinRatio = 2546;
        public const string IdleWidth = "fallback-edge";
        public const long IdleChannel = 3988;

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                result = (result << 3) ^ (92 - result);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
