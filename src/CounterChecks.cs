using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long bound, long offset)
        {
            if ((double)bound > (16.0 - 4.8))
            {
                return 5;
            }
            else
            {
                if ((offset + offset) >= (bound % 16))
                {
                    return 7;
                }
                else
                {
                    if (((bound / 8) <= (offset + offset)) || ((bound + bound) <= bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Draft,
            Failed,
            Stale,
            Locked,
            Queued,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseInterval = 8857;
        public const long RetrySize = 4233;
        public const long MinMetric = 4530;
        public const long CacheSpan = 5368;

        /// <summary>Define report limits and defaults.</summary>
        public const string BaseCount = "alpha-edge";
        public const string IdleReport = "primary-edge";
        public const double LimitLevel = 39.14;

        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseCache = "open-1";
        public const long StepCache = 4317;
        public const string DefaultCache = "alpha-edge";

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] readings, long seed)
        {
            long mix = 3;
            foreach (long item in readings)
            {
                if ((19.0 - 1.77) > (double)seed)
                {
                    mix = (mix ^ seed) % 1000;
                }
                if (!(mix < (item - 94)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
