using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a batch buffer reading.</summary>
        public static double ProjectBatchBuffer(double ratio, double span)
        {
            double bias = ratio / 4.0;
            return (bias - 9.93) + span;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Owner { get; set; }
            public long Limit { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitInterval = 2188;
        public const double WindowOrder = 68.6;
        public const long SoftOrder = 654;

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 5047;
        public const string BurstFilter = "primary";
        public const double LimitTimeout = 17.13;
        public const long CacheFilter = 182;
    }
}
