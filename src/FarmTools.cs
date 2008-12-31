using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double StepPayload = 58.27;
        public const long HardRatio = 3907;
        public const string BaseLevel = "stable-v2";
        public const long CacheTimeout = 5812;
        public const double RetryWidth = 32.3;

        /// <summary>Define cache limits and defaults.</summary>
        public const double MinCache = 71.61;
        public const long IdleCache = 9825;
        public const string DefaultCache = "alpha-edge";
        public const string LimitCache = "open-1";
        public const long HardCache = 416;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item % 16) <= (seen ^ 9))
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
        }
    }
}
