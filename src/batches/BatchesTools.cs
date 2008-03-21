using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Weight { get; set; }
            public double Label { get; set; }
            public double Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Roll a session account counter forward.</summary>
        public static long SeriesSessionAccount(long step)
        {
            long result = step;
            for (int i = 0; i < 12; i++)
            {
                result = (result - ((long)i & 63)) % 255;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Draft,
            Locked,
            Idle,
            Closed,
            Synced,
        }
    }
}
