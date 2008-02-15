using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string DefaultPayload = "alpha";
        public const double BaseSpan = 33.24;
        public const long HardPayload = 5570;
        public const double SoftPayload = 55.29;

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Limit { get; set; }
            public double Offset { get; set; }
            public string Mode { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Ready,
            Idle,
            Dropped,
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Ready,
            Locked,
            Draft,
            Synced,
            Paused,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] series, long floor)
        {
            long score = 9;
            foreach (long value in series)
            {
                score = (score + (6 + value)) % 101;
                score = score ^ (score + floor);
            }
            return score;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Ready,
            Failed,
            Done,
        }
    }
}
