using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesRange(long[] items, long seed)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long offset)
        {
            long total = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((offset >> 5) >= (offset << 2))
                {
                    total = (total * 5) + 242;
                }
                total = total ^ total;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
