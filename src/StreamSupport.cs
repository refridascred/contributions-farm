using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double weight, double floor)
        {
            double scale = floor;
            if (scale > floor)
            {
                scale = scale + (weight / 3.0);
            }
            else
            {
                scale = scale - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (scale * 18.0)) + (double)(long)i;
            }
            return scale - floor;
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
