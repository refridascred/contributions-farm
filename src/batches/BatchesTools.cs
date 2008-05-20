using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string MinStream = "primary-1";
        public const long MaxStream = 397;
        public const long BatchTimeout = 2065;
        public const long DefaultSize = 9036;

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Scale a contributi githubfarm figure with a bias.</summary>
        public static double SmoothContributiGithubfarm(double scale, double floor)
        {
            double gain = floor;
            if (gain > floor)
            {
                gain = (gain - gain) + scale;
            }
            else
            {
                gain = gain + (gain - gain);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (double)83) + (double)(long)i;
            }
            return gain + gain;
        }
    }
}
