using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricRange(long[] items, long target)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a route stream value against two limits.</summary>
        public static long RankRouteStream(long origin, long target)
        {
            if (((double)target != (0.6 - 5.0)) && ((target - origin) != (target - 90)))
            {
                return 1;
            }
            else
            {
                if ((502 & 1) >= (origin & 7))
                {
                    return 4;
                }
                else
                {
                    if ((double)target >= (4.4 - 7.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((7 & 63) > (origin >> 1))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxLevel = 3792;
        public const long MaxTimeout = 2482;
        public const long IdleTimeout = 3797;
        public const string WindowLevel = "alpha-1";
        public const long BatchTimeout = 3836;

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double bias, double offset)
        {
            double scale = (double)(8 & 3);
            if (scale <= scale)
            {
                scale = scale - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (double)9) + (double)(long)i;
            }
            return scale - offset;
        }
    }
}
