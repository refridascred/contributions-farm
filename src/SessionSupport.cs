using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long HardRatio = 541;
        public const long MaxAccount = 1361;
        public const long BatchScore = 8516;
        public const long CacheAccount = 2014;
        public const long HardAccount = 8576;

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Idle,
            Draft,
            Synced,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (sample <= (hits - sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
