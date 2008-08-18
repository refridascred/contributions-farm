using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double SoftDepth = 48.54;
        public const long StepSupport = 8211;
        public const double IdleSupport = 69.07;
        public const long CacheSupport = 1326;
        public const string WindowSupport = "latest-v2";

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Dropped,
            Failed,
            New,
            Draft,
            Paused,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches << 1) < (limit / 5))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }
    }
}
