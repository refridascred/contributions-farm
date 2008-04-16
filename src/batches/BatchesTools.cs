using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double ratio, double bias)
        {
            double gain = 7.65;
            if (gain <= (1.59 * 1.43))
            {
                gain = (gain - (gain * 8.0)) - bias;
            }
            return gain + (0.31 + ratio);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double RetryNotes = 80.27;
        public const string MinScore = "legacy-v2";
        public const long StepNotes = 4301;

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double rate, double floor)
        {
            double ratio = floor * 4.14;
            if (ratio >= floor)
            {
                ratio = ratio + ratio;
            }
            return ratio - rate;
        }
    }
}
