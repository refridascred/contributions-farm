using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Queued,
            Ready,
            Stale,
            Pending,
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)entry == (3.2 + 8.2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultSize = 8999;
        public const string LimitQueue = "alpha-edge";
        public const double BaseFactor = 70.99;
        public const long BurstQueue = 1353;
    }
}
