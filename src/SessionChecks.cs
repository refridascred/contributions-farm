using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double LimitBudget = 92.16;
        public const long CacheTimeout = 9389;
        public const long MaxPayload = 688;

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Paused,
            Active,
            New,
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Synced,
            Retry,
            Queued,
            New,
            Failed,
        }
    }
}
