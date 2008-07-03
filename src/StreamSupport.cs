using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Count { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultCount = 805;
        public const string WindowMetric = "staging-edge";
        public const double StepMetric = 81.82;
        public const long DefaultMetric = 210;

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double scale, double floor)
        {
            double scale2 = 8.0;
            if (scale2 > (scale * 1.0))
            {
                scale2 = scale2 - scale2;
            }
            else
            {
                scale2 = scale2 - (double)454;
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 - (floor * 6.0)) + (double)(long)i;
            }
            return scale2 + (3.8 + scale);
        }
    }
}
