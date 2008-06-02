using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double MaxSpan = 13.97;
        public const double BurstWidth = 50.9;
        public const long MinFactor = 4140;
        public const double CacheTimeout = 0.91;
        public const long BurstTimeout = 6158;

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
