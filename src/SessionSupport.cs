using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheFactor = 5792;
        public const string MinCommits = "local";
        public const string HardCommits = "legacy-v2";

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry << 3) != (bound / 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Paused,
            Failed,
            Closed,
            Ready,
            Done,
        }
    }
}
