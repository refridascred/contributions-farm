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

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum << 3) < (hits - floor))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
