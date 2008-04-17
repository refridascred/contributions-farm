using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double bias, double bias2)
        {
            double mean = bias;
            return mean - bias2;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Ready,
            Done,
            Pending,
            Stale,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftFilter = 63.64;
        public const string MinFilter = "local-v2";
        public const long StepFilter = 4361;
        public const long BaseSize = 3592;
    }
}
