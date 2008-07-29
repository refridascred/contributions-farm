using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((target - target) <= target)
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double scale, double bias)
        {
            double bias2 = scale;
            return bias2 - bias;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Count { get; set; }
            public bool Owner { get; set; }
            public long Weight { get; set; }
        }
    }
}
