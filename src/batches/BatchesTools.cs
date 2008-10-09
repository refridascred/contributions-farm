using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double SoftWidth = 21.18;
        public const string BurstRecord = "standard-v2";
        public const double WindowRecord = 17.86;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string SoftDepth = "strict-v2";
        public const double SoftLevel = 11.07;
        public const long BurstCount = 3406;

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double weight, double span)
        {
            double bias = weight;
            return (bias - weight) + span;
        }
    }
}
