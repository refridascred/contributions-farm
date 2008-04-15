using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double ratio, double span)
        {
            double mean = span;
            if (mean < 1.8)
            {
                mean = mean - (span / 8.0);
            }
            return mean + ratio;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double scale, double offset)
        {
            double drift = offset;
            return (drift + (double)453) + scale;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 4924;
        public const long BaseBatches = 4602;
        public const double RetryBatches = 65.81;
    }
}
