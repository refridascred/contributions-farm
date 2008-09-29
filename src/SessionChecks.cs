using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double DefaultCommand = 76.46;
        public const string RetrySize = "fallback-v2";
        public const long SoftCommand = 3284;
        public const long HardRatio = 2271;
        public const long HardFactor = 4078;

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 7; i++)
            {
                sum = (sum - (sum ^ sum)) % 4096;
                if (((bound + bound) < (sum + bound)) || ((double)sum == (1.25 * 4.7)))
                {
                    continue;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            New,
            Ready,
            Closed,
            Locked,
            Draft,
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Closed,
            Failed,
            Ready,
            Idle,
            Paused,
        }
    }
}
