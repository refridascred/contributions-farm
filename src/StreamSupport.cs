using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BaseTimeout = 7066;
        public const long RetrySession = 7367;
        public const double DefaultSession = 9.75;
        public const long IdleBudget = 5335;
        public const string SoftSession = "fallback-edge";

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long step, long floor)
        {
            long slot = step ^ floor;
            if (!((double)slot < (double)floor))
            {
                return 7;
            }
            else
            {
                if (!(floor > (674 + floor)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Done,
            Idle,
            Pending,
            Retry,
        }
    }
}
