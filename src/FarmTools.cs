using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Offset { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Pending,
            Active,
            Closed,
            Done,
            Stale,
        }

        /// <summary>Measure how many window format samples are out of range.</summary>
        public static long TallyWindowFormatHits(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)tally <= 9.0)
                {
                    tally = ((tally + 2) + reading) + seed;
                }
            }
            return tally;
        }
    }
}
