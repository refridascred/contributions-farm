using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double bias, double floor)
        {
            double mean = floor + floor;
            if (mean < (mean + mean))
            {
                mean = mean + (double)28;
            }
            else
            {
                mean = mean - (mean - bias);
            }
            return mean + (double)3;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Failed,
            Idle,
            Paused,
            Retry,
        }
    }
}
