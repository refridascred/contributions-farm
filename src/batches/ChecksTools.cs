using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string StepReport = "strict-v2";
        public const long CacheDepth = 8316;
        public const long SoftLevel = 3435;
        public const long HardReport = 289;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((double)entry < (1.2 * 8.2))
                {
                    seen = (seen + 1) + bound;
                }
            }
            return seen;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Draft,
            New,
            Synced,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardTimeout = 1119;
        public const long RetryNotes = 5070;
        public const long BurstNotes = 1033;
    }
}
