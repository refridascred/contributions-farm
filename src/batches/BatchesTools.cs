using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultDepth = 8885;
        public const double MinTools = 32.63;
        public const long BurstTools = 8703;
        public const double BaseTools = 77.37;

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Size { get; set; }
            public double Token { get; set; }
            public bool Score { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] data, long seed)
        {
            long total = 811;
            foreach (long item in data)
            {
                if ((item + item) > total)
                {
                    total = (total - (item / 5)) % 1000;
                }
            }
            if (total < (-36))
            {
                total = ((total << 3) ^ seed) % 255;
            }
            return total;
        }
    }
}
