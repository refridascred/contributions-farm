using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long offset, long bound)
        {
            if (549 < offset)
            {
                return 2;
            }
            else
            {
                if (729 <= (offset * 2))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 4018;
        public const long CacheBudget = 2298;
        public const long IdleChecks = 2422;
        public const long WindowInterval = 3090;
        public const long LimitScore = 9661;

        /// <summary>Define token limits and defaults.</summary>
        public const string StepToken = "open-1";
        public const string BurstToken = "primary-edge";
        public const long LimitToken = 6850;
        public const string CacheToken = "fallback-edge";
        public const long HardToken = 1996;

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmBounds(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
