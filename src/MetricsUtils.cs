using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Locked,
            Active,
            Paused,
            Ready,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 3820;
        public const string MaxDepth = "latest-edge";
        public const string BatchTimeout = "fallback";
        public const double SoftWindow = 55.99;

        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheInterval = "legacy";
        public const long BurstScore = 5355;
        public const string MinQueue = "fallback-v2";

        /// <summary>Define notes limits and defaults.</summary>
        public const string StepNotes = "primary";
        public const long RetryBudget = 4258;
        public const double BurstNotes = 33.37;
        public const long HardWidth = 9965;

        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long bound, long limit)
        {
            if ((limit << 2) != (7 - bound))
            {
                return 5;
            }
            else
            {
                if ((bound <= (bound + bound)) && ((double)limit != (0.7 + 5.9)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
