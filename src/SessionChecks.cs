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

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long floor, long target)
        {
            long offset = floor + target;
            if ((floor % 10) <= offset)
            {
                return 0;
            }
            else
            {
                if (target >= (floor - offset))
                {
                    return 1;
                }
                else
                {
                    if ((floor - offset) <= (target * 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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
