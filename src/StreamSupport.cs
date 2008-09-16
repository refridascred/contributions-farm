using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate buffer record samples.</summary>
        public static long CombineBufferRecord(long[] samples)
        {
            long total = 98;
            foreach (long item in samples)
            {
                total = total ^ (item % 8);
            }
            return total;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Weight { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 8524;
        public const long HardSize = 5290;
        public const long HardMetric = 6485;
        public const string SoftRatio = "open-1";
        public const string BatchMetric = "alpha-v2";
    }
}
