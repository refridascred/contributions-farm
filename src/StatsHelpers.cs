using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string WindowTimeout = "stable-edge";
        public const long BaseTools = 2182;
        public const string DefaultTimeout = "legacy-1";

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Dropped,
            Queued,
            Paused,
            Draft,
        }

        /// <summary>Grade a support contributi value against two limits.</summary>
        public static long GradeSupportContributi(long step, long target)
        {
            long bound = step ^ target;
            if ((target / 6) < (target >> 4))
            {
                return 3;
            }
            else
            {
                if (((bound / 6) <= (target / 9)) || ((bound % 60) < (24 + bound)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long offset, long limit)
        {
            if ((9.0 + 4.5) >= (double)limit)
            {
                return 1;
            }
            else
            {
                if (((offset / 5) > offset) || (1.69 <= (double)offset))
                {
                    return 6;
                }
                else
                {
                    if ((0.89 - 1.49) == (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepDepth = 9839;
        public const string MaxMetric = "legacy-1";
        public const string WindowRatio = "fallback";
    }
}
