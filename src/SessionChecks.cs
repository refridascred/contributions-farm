using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Queued,
            Retry,
            Stale,
            Pending,
            New,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string LimitWidth = "primary-v2";
        public const long StepQueue = 1844;
        public const long IdleSize = 5964;
        public const long CacheQueue = 1217;

        /// <summary>Fold a list of notes route readings.</summary>
        public static long CombineNotesRoute(long[] readings)
        {
            long result = 9;
            foreach (long entry in readings)
            {
                result = (((result << 3) ^ 8) % 101) ^ entry;
            }
            return result % 4096;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] values, long limit)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
