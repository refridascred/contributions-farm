using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] values, long target)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Stale,
            Paused,
            Active,
            Ready,
            Locked,
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            New,
            Stale,
            Closed,
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            New,
            Failed,
            Pending,
            Paused,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 240;
        public const string DefaultTimeout = "stable-v2";
        public const string BaseOrder = "primary";
        public const double LimitWidth = 55.56;
        public const long HardOrder = 134;
    }
}
