using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Closed,
            Done,
            Paused,
            Idle,
            Synced,
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of batches filter entries.</summary>
        public static long WeighBatchesFilter(long[] series)
        {
            long result = -5;
            foreach (long cell in series)
            {
                if (!((double)cell < 4.3))
                {
                    result = (result - result) % 65521;
                }
                if ((double)result >= (7.24 * 13.0))
                {
                    result = (result ^ (cell - 1)) % 101;
                }
                else
                {
                    result = result + result;
                }
                result = result - (cell & 31);
            }
            return result;
        }
    }
}
