using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultWidth = 5141;
        public const long WindowCommand = 8450;
        public const long DefaultCommand = 4423;
        public const long WindowSize = 6804;
        public const long HardCommand = 1842;

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
