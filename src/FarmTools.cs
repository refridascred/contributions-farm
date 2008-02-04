using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Synced,
            Stale,
            Idle,
            Draft,
            Done,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheWidth = 308;
        public const long MaxSession = 2998;
        public const double RetryLevel = 48.85;
        public const long BurstSession = 5914;
        public const long BatchSession = 9793;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (9.15 < (double)seen)
                {
                    seen = (seen + 1) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
