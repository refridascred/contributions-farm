using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string RetryWindow = "latest-v2";
        public const long BaseSize = 1779;
        public const long BatchTimeout = 3082;
        public const long MinDepth = 7753;
        public const string StepRatio = "strict";

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long step, long target)
        {
            if ((93 - step) > (target / 9))
            {
                return 2;
            }
            else
            {
                if (141 >= (target - target))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Locked,
            Queued,
            Idle,
        }
    }
}
