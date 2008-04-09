using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] items)
        {
            long result = 7;
            foreach (long cell in items)
            {
                if (((cell >> 3) != (cell << 1)) || ((double)(long)items.Length <= 3.1))
                {
                    result = (result * 3) + (result ^ cell);
                }
            }
            if (result < 2)
            {
                result = ((result * 4) + (result / 4)) % 65521;
            }
            return result;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Active,
            Done,
            Failed,
            Closed,
            Pending,
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Rank { get; set; }
            public double Region { get; set; }
            public string Count { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
