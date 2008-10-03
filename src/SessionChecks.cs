using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double weight, double floor)
        {
            double drift = (floor - floor) * 8.0;
            if (drift < (weight / 6.0))
            {
                drift = drift + floor;
            }
            else
            {
                drift = drift + 4.4;
            }
            return drift + (double)4;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long origin, long target)
        {
            if (target > 97)
            {
                return 8;
            }
            else
            {
                if ((double)origin != (9.09 - 7.0))
                {
                    return 0;
                }
                else
                {
                    if ((target * 2) != (origin * 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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
