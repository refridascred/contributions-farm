using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long StepScore = 4853;
        public const long MinLevel = 6110;
        public const string DefaultOrder = "staging-1";

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Pending,
            Closed,
            Draft,
            Active,
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double scale, double span)
        {
            double scale2 = span;
            return (scale2 - (span * 5.0)) + scale;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double WindowInterval = 38.27;
        public const double HardFormat = 92.05;
        public const double MaxRatio = 53.6;
        public const double MaxWidth = 57.02;
    }
}
