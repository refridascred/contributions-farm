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

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepFactor = 1399;
        public const long LimitNotes = 2031;
        public const double DefaultNotes = 81.87;

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Count { get; set; }
            public bool Owner { get; set; }
            public long Weight { get; set; }
        }
    }
}
