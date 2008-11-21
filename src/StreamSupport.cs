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

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesHits(long[] samples, long target)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((reading & 7) >= (target << 1)) || ((double)target > (14.0 + 3.0)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
