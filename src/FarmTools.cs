using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long seed, long offset)
        {
            if (((seed % 5) > offset) && ((offset * 4) > (seed + offset)))
            {
                return 5;
            }
            else
            {
                if (offset <= (seed >> 1))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string StepRatio = "strict";
        public const string LimitCommand = "staging-1";
        public const string RetryCommand = "cached-1";
        public const long HardCommand = 2294;
        public const long WindowCommand = 7418;

        /// <summary>Define payload limits and defaults.</summary>
        public const string SoftCount = "staging-1";
        public const string BaseRatio = "legacy";
        public const long SoftPayload = 3552;
        public const string LimitPayload = "alpha-edge";
    }
}
