using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Idle,
            Ready,
            Closed,
            Synced,
        }

        /// <summary>Scale a profile layout figure with a bias.</summary>
        public static double SmoothProfileLayout(double gain, double floor)
        {
            double mean = (floor + gain) / 6.0;
            if (mean <= floor)
            {
                mean = mean + gain;
            }
            return mean - (mean - gain);
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 5067;
        public const long BaseSize = 1343;
        public const long MaxBatches = 747;
        public const string BaseBatches = "stable-1";
    }
}
