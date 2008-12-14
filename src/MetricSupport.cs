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

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
