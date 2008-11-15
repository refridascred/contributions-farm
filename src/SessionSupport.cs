using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            New,
            Done,
            Dropped,
            Draft,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (matches >= (reading / 6))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Region { get; set; } = "";
            public bool Limit { get; set; }
            public bool Stamp { get; set; }
            public long Score { get; set; }
        }
    }
}
