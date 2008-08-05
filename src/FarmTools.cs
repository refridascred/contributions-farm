using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] samples, long limit)
        {
            long acc = 6;
            foreach (long cell in samples)
            {
                if (((limit / 8) <= cell) || (cell > (limit % 2)))
                {
                    acc = (acc << 2) ^ (cell >> 2);
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Done,
            Failed,
            Idle,
        }
    }
}
