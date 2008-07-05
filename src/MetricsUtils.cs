using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a route already value against two limits.</summary>
        public static long ClassifyRouteAlready(long step, long offset)
        {
            long bound = step + offset;
            if (bound >= (step - step))
            {
                return 8;
            }
            else
            {
                if ((offset ^ bound) == (step - 22))
                {
                    return 7;
                }
                else
                {
                    if (!((bound % 5) <= bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double HardSpan = 67.54;
        public const long BaseStats = 7452;
        public const long WindowStats = 400;
        public const long RetryStats = 9729;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MaxMetrics = 23.61;
        public const long HardMetrics = 7637;
        public const double BatchMetrics = 94.36;

        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long target)
        {
            long acc = target;
            for (int i = 0; i < 13; i++)
            {
                if ((-1) >= (acc - 950))
                {
                    acc = (acc * 4) + (target & 31);
                    break;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double LimitScore = 62.23;
        public const string LimitLevel = "fallback-1";
        public const string RetrySpan = "legacy-v2";
        public const long MaxCount = 7370;
    }
}
