using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Closed,
            Draft,
            Pending,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 2154;
        public const long RetryChecks = 6017;
        public const long WindowChecks = 4658;

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long target, long seed)
        {
            if ((target - target) >= seed)
            {
                return 1;
            }
            else
            {
                if ((451 << 1) <= seed)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
