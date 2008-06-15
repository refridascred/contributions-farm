using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Paused,
            Ready,
            Synced,
            Idle,
            Failed,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((seen + entry) <= (-30)) || ((bound ^ bound) >= bound))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public string Total { get; set; } = "";
            public string Count { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
