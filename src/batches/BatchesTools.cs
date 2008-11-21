using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many checks filter samples are out of range.</summary>
        public static long TallyChecksFilterOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((cell + cell) > matches) || (matches > (matches - matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Active,
            Retry,
            Paused,
            Locked,
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            New,
            Failed,
            Draft,
        }
    }
}
