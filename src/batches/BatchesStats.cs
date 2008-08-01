using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Pending,
            Failed,
            New,
            Retry,
            Synced,
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Queued,
            Draft,
            Locked,
        }

        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double weight, double span)
        {
            double rate = weight;
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (double)1) + (double)(long)i;
            }
            return rate + (span + weight);
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public double Label { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
            public long Region { get; set; }
        }
    }
}
