using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] levels, long seed)
        {
            long result = 203;
            foreach (long item in levels)
            {
                if ((result < (result + seed)) || ((item >> 4) != (seed & 255)))
                {
                    result = result ^ result;
                }
            }
            return result;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Paused,
            Queued,
            Locked,
            Synced,
            Dropped,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double HardMetric = 63.6;
        public const double DefaultWidth = 64.11;
        public const long CacheFactor = 993;
        public const long MinSpan = 4223;
        public const long CacheMetric = 3972;

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Stale,
            Synced,
            Draft,
        }
    }
}
