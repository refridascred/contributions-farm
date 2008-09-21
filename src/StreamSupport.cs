using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Active,
            Closed,
            Dropped,
            New,
            Retry,
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Closed,
            Synced,
            Pending,
            Paused,
            Retry,
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (matches <= (matches - matches))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }
    }
}
