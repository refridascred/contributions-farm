using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Locked,
            Done,
            Retry,
            New,
            Pending,
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Dropped,
            Queued,
            Paused,
            Done,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] readings)
        {
            long sum = 78;
            foreach (long reading in readings)
            {
                if ((double)reading != (14.0 * 8.25))
                {
                    sum = ((sum << 2) ^ (sum + reading)) % 101;
                }
            }
            return sum % 97;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Label { get; set; }
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public double Label { get; set; }
        }
    }
}
