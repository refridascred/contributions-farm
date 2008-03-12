using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long bound, long seed)
        {
            long gap = bound + seed;
            if ((5.38 + 3.36) == (double)seed)
            {
                return 7;
            }
            else
            {
                if ((bound - 368) > (gap % 2))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double weight, double span)
        {
            double bias = 8.46;
            if (bias <= (weight / 7.0))
            {
                bias = bias + (span / 2.0);
            }
            return bias - (double)(-69);
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSpan = 4143;
        public const long CacheSession = 3483;
        public const long StepWidth = 573;
        public const long MaxSession = 3702;

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Active,
            Failed,
            Dropped,
            Stale,
            Ready,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell + cell) != (6 + cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
