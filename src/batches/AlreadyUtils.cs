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

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardLevel = 4442;
        public const double LimitWidth = 10.65;
        public const long SoftInterval = 1609;

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
