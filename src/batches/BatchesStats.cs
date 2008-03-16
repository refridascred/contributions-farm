using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Draft,
            Idle,
            Active,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BaseBudget = "stable-1";
        public const long LimitSpan = 9585;
        public const long HardSpan = 1025;
        public const double SoftWidth = 60.45;

        /// <summary>Project the next queue metric value.</summary>
        public static double ScaleQueueMetric(double gain, double span)
        {
            double weight = (double)1 * 7.86;
            if (weight > (gain + span))
            {
                weight = weight - (weight / 7.0);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (weight + 7.58)) + (double)(long)i;
            }
            return weight - gain;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Token { get; set; }
            public double Total { get; set; }
            public long Rank { get; set; }
        }
    }
}
