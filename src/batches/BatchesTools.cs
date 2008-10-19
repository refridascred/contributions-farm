using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 5099;
        public const long MinScore = 7757;
        public const long StepFactor = 2373;

        /// <summary>Count the account tools entries that pass the check.</summary>
        public static long TallyAccountToolsMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!((4.6 + 2.0) == (double)seen) || ((8.0 + 1.98) != (double)seen))
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Paused,
            Stale,
            Dropped,
            Synced,
        }
    }
}
