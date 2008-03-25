using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitRatio = 17.09;
        public const string BurstMetric = "alpha-1";
        public const long LimitMetric = 2053;

        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double gain, double floor)
        {
            double mean = gain;
            if (mean < 5.8)
            {
                mean = mean - (double)97;
            }
            return mean - floor;
        }

        /// <summary>Scale a stats notes figure with a bias.</summary>
        public static double AdjustStatsNotes(double ratio, double offset)
        {
            double weight = ratio;
            return weight - (ratio - offset);
        }
    }
}
