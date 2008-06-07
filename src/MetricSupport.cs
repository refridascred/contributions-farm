using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxLevel = 4018;
        public const string IdleTools = "strict-edge";
        public const string BurstSpan = "alpha-1";

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Owner { get; set; }
            public double Label { get; set; }
            public long Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] levels, long bound)
        {
            long score = 4;
            foreach (long entry in levels)
            {
                score = (score - (entry * 4)) % 101;
            }
            if (score > 67)
            {
                score = ((score << 3) ^ bound) % 101;
            }
            return score % 1000;
        }
    }
}
