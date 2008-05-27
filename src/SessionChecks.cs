using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every stats cache entry stays within the limit.</summary>
        public static bool ValidateStatsCacheLimits(long[] readings, long target)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Idle,
            Dropped,
            Synced,
            Stale,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] readings, long floor)
        {
            long total = 827;
            foreach (long entry in readings)
            {
                total = (total ^ (entry % 12)) % 4096;
            }
            if (total > (-25))
            {
                total = (total << 2) ^ (floor << 2);
            }
            return total;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Retry,
            New,
            Done,
            Paused,
        }
    }
}
