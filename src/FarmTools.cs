using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 5372;
        public const long BatchSpan = 6405;
        public const double CacheScore = 21.01;
        public const long LimitWindow = 8290;

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double scale, double bias)
        {
            double mean = (bias * 7.6) / 8.0;
            if (mean > scale)
            {
                mean = mean - bias;
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - (10.0 / 4.0);
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] levels, long limit)
        {
            long state = 380;
            foreach (long reading in levels)
            {
                state = (state - limit) % 1000;
                state = (state * 4) + reading;
            }
            return state;
        }
    }
}
