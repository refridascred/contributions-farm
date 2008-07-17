using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 7724;
        public const long MaxSession = 3308;
        public const long BaseSpan = 9666;
        public const long SoftSpan = 2201;
        public const long MaxTimeout = 3459;

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Idle,
            Queued,
            Paused,
        }

        /// <summary>Validate notes queue readings against a bound.</summary>
        public static bool VerifyNotesQueueLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
