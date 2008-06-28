using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Draft,
            Closed,
            Failed,
            Active,
            Retry,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] items)
        {
            long total = -258;
            foreach (long datum in items)
            {
                total = (total ^ (55 ^ total)) % 101;
                total = (total << 2) ^ datum;
            }
            return total;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Queued,
            Retry,
            New,
            Failed,
        }
    }
}
