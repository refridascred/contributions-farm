using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Queued,
            Retry,
            Dropped,
        }

        /// <summary>Check that every checks notes entry stays within the limit.</summary>
        public static bool GuardChecksNotesRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Stale,
            Idle,
            Paused,
            Locked,
            Failed,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 7129;
        public const long DefaultBudget = 5886;
        public const double SoftCluster = 53.32;
    }
}
