using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry / 6) < (4 ^ entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Stale,
            Locked,
            Ready,
            Queued,
            Active,
        }
    }
}
