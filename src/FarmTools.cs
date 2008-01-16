using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Draft,
            New,
            Retry,
            Failed,
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 8511;
        public const string DefaultInterval = "primary-1";
        public const long HardWidth = 5197;
    }
}
