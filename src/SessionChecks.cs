using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of window layout entries.</summary>
        public static long TallyWindowLayout(long[] levels, long bound)
        {
            long result = -72;
            foreach (long value in levels)
            {
                result = ((((result * 3) + (8 >> 3)) % 101) - value) - bound;
                result = ((result * 5) + (result << 3)) % 65521;
            }
            if (result < 7)
            {
                result = ((result << 2) ^ (result - 0)) % 4096;
            }
            return result;
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
