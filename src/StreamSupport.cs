using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Queued,
            Closed,
            Pending,
            Dropped,
            Idle,
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Ratio { get; set; } = "";
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
