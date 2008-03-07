using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string DefaultStats = "strict-edge";
        public const double BaseStats = 33.75;
        public const long StepScore = 8580;
        public const long MinScore = 1781;
        public const double DefaultDepth = 42.63;

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long seed)
        {
            long result = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((double)(long)i >= (3.0 - 17.0))
                {
                    result = result + seed;
                }
                result = (result ^ 461) % 255;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double ratio, double floor)
        {
            double bias = ratio;
            if (bias >= (double)(-960))
            {
                bias = (bias + 6.54) + floor;
            }
            return bias + (double)7;
        }
    }
}
