using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Limit { get; set; }
            public string Label { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleScore = 7936;
        public const long CacheSize = 2321;
        public const long MinOrder = 3303;
        public const double RetryOrder = 28.05;

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double BlendBatch(double bias, double offset)
        {
            double gain = bias;
            if (gain <= offset)
            {
                gain = gain - (9.0 * 1.8);
            }
            return gain + offset;
        }
    }
}
