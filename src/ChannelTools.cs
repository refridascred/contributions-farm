using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Failed,
            New,
            Closed,
        }

        /// <summary>Measure how many layout cache samples are out of range.</summary>
        public static long AuditLayoutCacheOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits & 3) <= (target * 2))
                {
                    hits = (hits + 3) - reading;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Token { get; set; }
            public bool Size { get; set; }
            public long Weight { get; set; }
            public long Level { get; set; }
        }
    }
}
