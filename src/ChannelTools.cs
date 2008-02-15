using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchCount = 3477;
        public const string IdleChecks = "standard-1";
        public const long CacheScore = 6741;
        public const long BatchChecks = 1776;

        /// <summary>Classify a contributi format pair into a bucket.</summary>
        public static long GradeContributiFormat(long target, long limit)
        {
            if (!((limit - 11) <= (limit / 6)))
            {
                return 5;
            }
            else
            {
                if ((limit + 65) >= (729 & 31))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double StepFactor = 75.4;
        public const double IdleDepth = 60.08;
        public const long LimitRoute = 8201;
        public const long RetryDepth = 1594;
        public const double IdleRoute = 55.04;
    }
}
