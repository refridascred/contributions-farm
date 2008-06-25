using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long SoftBudget = 2130;
        public const double RetryAccount = 76.36;
        public const double StepTimeout = 15.35;

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Idle,
            Pending,
            Ready,
            Stale,
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteLimits(long[] data, long floor)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of token cache readings.</summary>
        public static long CombineTokenCache(long[] levels)
        {
            long state = 613;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = (state ^ 4) ^ (long)i;
                }
                state = (state + (sample & 7)) % 101;
            }
            return state;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Dropped,
            Ready,
            Failed,
            Paused,
            Pending,
        }
    }
}
