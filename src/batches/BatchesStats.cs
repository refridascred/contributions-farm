using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many metric already samples are out of range.</summary>
        public static long AuditMetricAlreadyHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((step + step) > (value * 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] items)
        {
            long result = 196;
            foreach (long datum in items)
            {
                result = ((result << 3) ^ (result + (-34))) ^ datum;
            }
            return result;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Total { get; set; }
            public double Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Token { get; set; }
            public bool Region { get; set; }
            public double Weight { get; set; }
            public long Label { get; set; }
        }
    }
}
