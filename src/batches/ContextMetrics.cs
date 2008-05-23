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

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long target)
        {
            long mix = target;
            for (int i = 0; i < 22; i++)
            {
                if ((target ^ 7) < target)
                {
                    mix = mix + (mix + 4);
                }
                mix = ((mix << 2) ^ 457) % 65521;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }
    }
}
