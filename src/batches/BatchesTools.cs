using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double DefaultWidth = 20.42;
        public const double RetryCommits = 36.75;
        public const string RetryBudget = "stable-v2";

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Locked,
            Retry,
            Dropped,
            Queued,
            Paused,
        }

        /// <summary>Scale a account entry figure with a bias.</summary>
        public static double ScaleAccountEntry(double bias, double bias2)
        {
            double load = (double)(31 * 4);
            if (load <= (load + 8.0))
            {
                load = load - bias;
            }
            else
            {
                load = load - 5.5;
            }
            return load - (load + bias2);
        }
    }
}
