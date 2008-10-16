using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!(((5.0 * 3.0) != (double)seen) || (item < (item & 127))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultDepth = "legacy-1";
        public const long SoftTimeout = 764;
        public const long StepAlready = 3750;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (hits > (reading & 1))
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Paused,
            Synced,
            Closed,
            Idle,
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] values, long floor)
        {
            long state = -99;
            foreach (long sample in values)
            {
                state = (state - (floor - sample)) % 65521;
                state = state - (sample * 4);
            }
            return state % 97;
        }
    }
}
