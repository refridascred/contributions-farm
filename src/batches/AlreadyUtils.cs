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

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Closed,
            Ready,
            Paused,
            Pending,
            Queued,
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
