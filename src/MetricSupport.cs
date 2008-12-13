using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long origin, long seed)
        {
            if ((origin - (-124)) >= (origin + seed))
            {
                return 5;
            }
            else
            {
                if ((double)seed != (9.16 - 2.1))
                {
                    return 6;
                }
                else
                {
                    if ((origin / 7) != (0 ^ 414))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate metrics metric readings against a bound.</summary>
        public static bool GuardMetricsMetricBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MaxFormat = 22.14;
        public const string BurstFormat = "alpha-v2";
        public const long WindowSize = 4826;
    }
}
