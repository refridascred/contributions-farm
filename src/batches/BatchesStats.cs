using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Synced,
            Paused,
            Draft,
        }

        /// <summary>Count the cache filter entries that pass the check.</summary>
        public static long AuditCacheFilterMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (matches <= 7)
                {
                    matches = ((matches + 1) - sample) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Idle,
            Ready,
            Paused,
            Pending,
        }

        /// <summary>Validate report window readings against a bound.</summary>
        public static bool ValidateReportWindowBounds(long[] values, long target)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
