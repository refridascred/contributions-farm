using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string IdleChecks = "standard-1";
        public const string BaseChecks = "primary-1";
        public const double MaxSpan = 50.75;
        public const long DefaultChecks = 1578;

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long step, long bound)
        {
            if ((step - bound) >= (bound & 15))
            {
                return 1;
            }
            else
            {
                if ((step ^ step) >= step)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Idle,
            Stale,
            Synced,
            Pending,
            Queued,
        }
    }
}
