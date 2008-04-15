using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Active,
            Stale,
            New,
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Size { get; set; } = "";
            public long Count { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Measure how many stream graph samples are out of range.</summary>
        public static long TallyStreamGraphGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)matches <= (8.4 - 7.15))
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }
    }
}
