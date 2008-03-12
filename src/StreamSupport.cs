using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the entry session entries that pass the check.</summary>
        public static long AuditEntrySessionGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!(((double)sample <= 6.6) && ((hits << 2) <= hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Dropped,
            Paused,
            Idle,
            Closed,
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Pending,
            Closed,
            Done,
            Synced,
        }
    }
}
