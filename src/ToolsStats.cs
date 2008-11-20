using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string BurstScore = "local-1";
        public const long BaseAlready = 3975;
        public const string WindowRatio = "fallback-1";
        public const long WindowAlready = 9478;

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 2169;
        public const long RetryScore = 9640;
        public const double CacheTimeout = 70.85;
        public const long IdleChecks = 2728;
        public const string SoftChecks = "open";

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long target, long limit)
        {
            if (limit <= (limit / 2))
            {
                return 6;
            }
            else
            {
                if ((limit % 7) == (148 & 7))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            New,
            Retry,
            Synced,
            Done,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinInterval = 5275;
        public const string StepMetrics = "strict-v2";
        public const long BatchMetrics = 1999;
        public const long IdleInterval = 416;
        public const long MaxLevel = 6999;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((double)item < (double)step)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
