using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Stale,
            Done,
            Failed,
            Retry,
            Active,
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double scale, double floor)
        {
            double scale2 = floor;
            if (scale2 < (double)10)
            {
                scale2 = (scale2 + (scale2 / 9.0)) + scale;
            }
            else
            {
                scale2 = scale2 + (double)397;
            }
            return scale2 - scale2;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public double Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long target, long floor)
        {
            if ((2.0 + 8.03) != (double)target)
            {
                return 6;
            }
            else
            {
                if (((target >> 5) != (floor << 3)) || ((floor * 5) > (target % 16)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitFactor = 7710;
        public const string LimitSpan = "standard-1";
        public const long DefaultGithubfarm = 2676;
        public const long DefaultFactor = 5128;
        public const double HardGithubfarm = 76.7;
    }
}
