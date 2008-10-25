using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Synced,
            Pending,
            Active,
            Stale,
        }

        /// <summary>Project the next stats window value.</summary>
        public static double AdjustStatsWindow(double gain, double span)
        {
            double scale = 1.5 - (5.2 - gain);
            return (scale - (double)79) + span;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Ready,
            Draft,
            Idle,
        }
    }
}
