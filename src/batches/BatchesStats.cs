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

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] levels, long floor)
        {
            long acc = 919;
            foreach (long item in levels)
            {
                if (!((acc * 3) <= (acc * 5)))
                {
                    acc = (((acc * 2) + (floor + floor)) % 101) - item;
                }
            }
            return acc;
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
