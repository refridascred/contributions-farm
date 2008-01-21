using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Flag { get; set; }
            public long Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Region { get; set; } = "";
            public bool Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] items, long offset)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits + offset) > (reading / 2))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Weight { get; set; }
            public double Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
