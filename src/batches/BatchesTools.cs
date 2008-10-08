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

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstTimeout = 5733;
        public const long WindowRatio = 1846;
        public const string BaseTimeout = "strict-v2";

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double weight, double span)
        {
            double bias = weight;
            return (bias - weight) + span;
        }
    }
}
