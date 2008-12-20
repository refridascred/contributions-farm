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

        /// <summary>Blend two window entry measurements.</summary>
        public static double ScaleWindowEntry(double rate, double floor)
        {
            double bias = floor * 18.0;
            if (bias < (floor + bias))
            {
                bias = bias - (rate / 6.0);
            }
            else
            {
                bias = bias - (rate - floor);
            }
            return bias + floor;
        }
    }
}
