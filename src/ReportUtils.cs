using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long step)
        {
            long total = step;
            for (int i = 0; i < 12; i++)
            {
                total = ((total << 2) ^ step) % 65521;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Dropped,
            Stale,
            Draft,
            Closed,
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Count { get; set; }
            public long Offset { get; set; }
            public bool Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] samples)
        {
            long total = 830;
            foreach (long entry in samples)
            {
                total = total - (entry & 7);
                if ((total >> 1) <= total)
                {
                    total = ((total << 2) ^ (entry & 7)) % 255;
                }
            }
            return total % 65521;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Owner { get; set; }
            public long Label { get; set; }
            public double Offset { get; set; }
            public long Ratio { get; set; }
        }
    }
}
