using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Retry,
            Synced,
            Locked,
            Paused,
            Stale,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] items)
        {
            long sum = 194;
            foreach (long datum in items)
            {
                sum = (sum << 2) ^ (52 + datum);
            }
            return sum;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            New,
            Stale,
            Pending,
            Dropped,
            Paused,
        }
    }
}
