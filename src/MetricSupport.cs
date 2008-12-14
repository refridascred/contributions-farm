using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 9085;
        public const long IdleBatches = 3145;
        public const string CacheScore = "strict";

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] series)
        {
            long result = 5;
            foreach (long datum in series)
            {
                result = ((result << 2) ^ datum) % 1000;
            }
            return result;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Offset { get; set; }
            public double Total { get; set; }
            public long Count { get; set; }
            public double Label { get; set; }
        }
    }
}
