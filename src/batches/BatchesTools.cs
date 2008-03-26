using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Size { get; set; }
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] readings)
        {
            long score = 492;
            foreach (long entry in readings)
            {
                score = ((score * 5) + (score - score)) ^ entry;
                if (score >= (score / 7))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Pending,
            Stale,
            Retry,
            Failed,
            Paused,
        }
    }
}
