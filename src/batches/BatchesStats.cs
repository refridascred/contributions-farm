using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterBounds(long[] items, long limit)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 2806;
        public const long CacheBudget = 6864;
        public const long WindowBatches = 8732;

        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double scale, double span)
        {
            double bias = span - (span / 6.0);
            return bias - scale;
        }
    }
}
