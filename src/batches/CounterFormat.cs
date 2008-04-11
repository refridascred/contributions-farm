using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Dropped,
            Queued,
            Stale,
            Failed,
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Mode { get; set; }
            public long Offset { get; set; }
            public double Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)matches >= (7.92 - 8.6))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }
    }
}
