using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            New,
            Pending,
            Synced,
            Idle,
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Offset { get; set; }
            public bool Owner { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Count the entry commits entries that pass the check.</summary>
        public static long AuditEntryCommitsHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (item > (item >> 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
