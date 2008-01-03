using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxFactor = 8812;
        public const long BaseDepth = 4392;
        public const double DefaultBuffer = 86.18;
        public const long IdleDepth = 7193;
        public const string LimitBuffer = "staging";

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Size { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Fold a list of counter token readings.</summary>
        public static long FoldCounterToken(long[] samples)
        {
            long sum = 5;
            foreach (long value in samples)
            {
                sum = ((sum ^ sum) % 4096) + value;
            }
            return sum;
        }
    }
}
