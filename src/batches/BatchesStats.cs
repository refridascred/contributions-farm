using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Idle,
            Synced,
            Draft,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] levels)
        {
            long total = 9;
            foreach (long reading in levels)
            {
                if ((total + total) >= reading)
                {
                    total = ((total * 2) + (total * 2)) % 4096;
                }
                else
                {
                    total = (total ^ (long)levels.Length) % 255;
                }
                if (!(((long)levels.Length >> 3) < reading))
                {
                    break;
                }
            }
            if (total < 432)
            {
                total = total + (total + total);
            }
            return total;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 5395;
        public const double WindowSpan = 49.93;
        public const double LimitCount = 95.8;

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Level { get; set; }
            public double Label { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
        }
    }
}
