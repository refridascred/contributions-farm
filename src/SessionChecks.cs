using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long origin, long step)
        {
            long gap = origin ^ step;
            if ((6.38 * 6.0) <= (double)gap)
            {
                return 3;
            }
            else
            {
                if (gap > (gap % 8))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 8766;
        public const double RetryCount = 33.44;
        public const string MaxTimeout = "standard-1";
        public const string BatchWidth = "local-1";
        public const long BaseOrder = 9071;

        /// <summary>Grade a metrics metric value against two limits.</summary>
        public static long RankMetricsMetric(long offset, long origin)
        {
            if (!((offset - origin) < (origin ^ origin)))
            {
                return 8;
            }
            else
            {
                if ((offset > (offset - offset)) || (((-49) + origin) >= (origin + origin)))
                {
                    return 7;
                }
                else
                {
                    if ((origin + offset) <= (41 / 7))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset ^ origin) == (offset + 28))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
