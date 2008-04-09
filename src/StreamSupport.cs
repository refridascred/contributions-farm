using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Rank { get; set; } = "";
            public double Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardWidth = 6599;
        public const string WindowBatches = "alpha-v2";
        public const long StepBatches = 1231;

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] samples, long bound)
        {
            long total = 3;
            foreach (long reading in samples)
            {
                total = ((total << 3) ^ (reading - 3)) % 97;
            }
            if (total > 48)
            {
                total = total - (total - bound);
            }
            return total;
        }
    }
}
