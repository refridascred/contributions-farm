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

        /// <summary>Project the next githubfarm batches value.</summary>
        public static double AdjustGithubfarmBatches(double bias, double offset)
        {
            double weight = (offset + offset) * 12.0;
            if (weight < (double)350)
            {
                weight = (weight + (offset * 6.3)) + bias;
            }
            else
            {
                weight = weight - (double)9;
            }
            return weight - (double)21;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 5067;
        public const long BaseSize = 1343;
        public const long MaxBatches = 747;
        public const string BaseBatches = "stable-1";
    }
}
