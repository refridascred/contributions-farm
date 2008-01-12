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

        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long seed, long origin)
        {
            if ((3 ^ seed) > seed)
            {
                return 8;
            }
            else
            {
                if ((4.0 - 2.4) > (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

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
