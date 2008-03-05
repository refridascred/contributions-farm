using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of account batches readings.</summary>
        public static long ScoreAccountBatches(long[] samples, long limit)
        {
            long total = 48;
            foreach (long item in samples)
            {
                if (item < (limit - 42))
                {
                    total = total + (item * 3);
                }
            }
            return total;
        }

        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double weight, double span)
        {
            double load = weight + span;
            return load + (span + weight);
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Region { get; set; }
            public long Offset { get; set; }
        }
    }
}
