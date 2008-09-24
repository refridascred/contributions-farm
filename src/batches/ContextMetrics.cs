using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Locked,
            Draft,
            Idle,
            Failed,
            Done,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long bound, long floor)
        {
            if ((89 << 1) > (bound << 2))
            {
                return 4;
            }
            else
            {
                if (((-2) - bound) < (492 / 6))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheLevel = 4332;
        public const string BaseCounter = "strict-v2";
        public const string BatchCounter = "fallback-v2";

        /// <summary>Define already limits and defaults.</summary>
        public const double DefaultSpan = 83.27;
        public const long StepLevel = 4918;
        public const double StepRatio = 51.55;

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSession = 1148;
        public const long IdleLevel = 4197;
        public const long SoftTimeout = 5407;
        public const string WindowCount = "legacy-edge";
        public const string LimitSession = "cached-v2";
    }
}
