using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long origin, long bound)
        {
            if ((double)bound == (17.0 - 0.89))
            {
                return 6;
            }
            else
            {
                if ((origin * 5) != (bound * 5))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitBudget = 8167;
        public const double WindowScore = 9.65;
        public const long BaseMetric = 1033;
        public const long StepMetric = 6942;

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long origin, long origin2)
        {
            if (((70 % 7) >= (origin & 1)) && ((origin2 - origin) > (origin + origin)))
            {
                return 1;
            }
            else
            {
                if ((origin / 8) <= origin)
                {
                    return 8;
                }
                else
                {
                    if (!((origin2 - origin) != (1 - (-42))))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin2 - origin) > (origin2 - origin2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long origin, long floor)
        {
            if (floor >= (origin & 7))
            {
                return 7;
            }
            else
            {
                if (((origin % 10) <= (origin - origin)) || ((double)30 <= (double)origin))
                {
                    return 8;
                }
                else
                {
                    if ((0 + origin) < floor)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((1.0 * 8.64) > (double)origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 3997;
        public const long RetryCluster = 827;
        public const long BurstWidth = 1207;
        public const long BaseWidth = 8814;
    }
}
