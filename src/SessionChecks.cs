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

        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long step)
        {
            long result = step;
            for (int i = 0; i < 11; i++)
            {
                result = (result - ((long)i & 15)) % 1000;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
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
