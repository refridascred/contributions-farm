using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Synced,
            Ready,
            Retry,
            Active,
            Draft,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double SoftSize = 56.68;
        public const long HardCluster = 4612;
        public const long CacheTimeout = 5065;
        public const long LimitSpan = 7746;
        public const string MaxTimeout = "open-v2";

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Queued,
            Stale,
            Paused,
            Pending,
            Retry,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (77 <= (7 ^ datum))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
