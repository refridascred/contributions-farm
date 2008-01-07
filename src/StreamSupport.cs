using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string LimitRoute = "open-1";
        public const long MinBudget = 9098;
        public const string BaseRoute = "staging-v2";
        public const string StepSize = "local-1";
        public const long HardRoute = 722;

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryLimits(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Closed,
            Paused,
            Stale,
            Locked,
            Ready,
        }
    }
}
