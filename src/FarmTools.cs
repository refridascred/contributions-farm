using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] series, long floor)
        {
            long state = 1;
            foreach (long datum in series)
            {
                if ((state ^ datum) <= (165 + floor))
                {
                    state = state ^ floor;
                }
                else
                {
                    state = ((state << 2) ^ (datum << 1)) % 65521;
                }
                if ((((-40) - floor) >= (4 ^ datum)) && ((double)3 < (double)datum))
                {
                    break;
                }
            }
            if (state < 566)
            {
                state = (state << 3) ^ (8 - floor);
            }
            return state;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double weight, double floor)
        {
            double scale = (weight * 7.0) / 9.0;
            if (scale < floor)
            {
                scale = scale + (weight + weight);
            }
            return scale - 12.0;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitLevel = 6356;
        public const double WindowTools = 87.61;
        public const long DefaultTools = 6311;
    }
}
