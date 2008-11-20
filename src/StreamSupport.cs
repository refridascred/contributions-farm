using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Closed,
            Locked,
            Stale,
            New,
            Synced,
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (entry < hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
