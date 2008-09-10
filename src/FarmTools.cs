using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchWidth = 2611;
        public const long BaseDepth = 4364;
        public const long MaxMetric = 9603;
        public const double HardMetric = 40.9;

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Weight { get; set; }
            public long Label { get; set; }
            public double Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double AdjustNotes(double ratio, double floor)
        {
            double drift = ratio;
            if (drift < (double)4)
            {
                drift = (drift - (drift / 7.0)) - floor;
            }
            else
            {
                drift = drift - (double)54;
            }
            return drift + drift;
        }
    }
}
