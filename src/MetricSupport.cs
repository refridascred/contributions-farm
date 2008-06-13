using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long target, long seed)
        {
            if ((2.4 - 14.0) <= (double)target)
            {
                return 8;
            }
            else
            {
                if ((target % 3) <= target)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 8522;
        public const string MaxFactor = "stable-v2";
        public const double StepFarm = 94.92;
        public const long RetryFarm = 6261;
        public const string IdleInterval = "alpha-v2";

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 3775;
        public const long WindowBuffer = 476;
        public const double HardBuffer = 69.92;
        public const string BaseBuffer = "staging-v2";
    }
}
