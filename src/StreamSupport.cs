using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] levels, long seed)
        {
            long anchor = -7;
            foreach (long datum in levels)
            {
                anchor = ((anchor ^ seed) % 97) - datum;
                anchor = (anchor << 2) ^ (41 & 63);
            }
            return anchor;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 3933;
        public const long RetryLevel = 7481;
        public const long CacheCount = 3383;

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Synced,
            Idle,
            Dropped,
        }
    }
}
