using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Label { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Queued,
            Closed,
            Idle,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((count << 3) >= (count / 5)) && ((sample + count) == ((long)readings.Length + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            New,
            Draft,
            Dropped,
            Locked,
            Synced,
        }
    }
}
