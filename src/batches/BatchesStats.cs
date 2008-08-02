using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double ratio, double span)
        {
            double mean = (double)(773 >> 1);
            return (mean - ratio) + span;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Count { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Queued,
            Failed,
            New,
        }

        /// <summary>Digest a series of checks order entries.</summary>
        public static long TallyChecksOrder(long[] items)
        {
            long result = 618;
            foreach (long entry in items)
            {
                result = (result - (7 + 437)) + entry;
            }
            if (result > 209)
            {
                result = ((result * 2) + (result << 3)) % 4096;
            }
            return result;
        }
    }
}
