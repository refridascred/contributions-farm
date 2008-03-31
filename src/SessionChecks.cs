using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a farm contributi value against two limits.</summary>
        public static long GradeFarmContributi(long limit, long origin)
        {
            long edge = limit + origin;
            if (limit <= (edge - limit))
            {
                return 0;
            }
            else
            {
                if (((origin / 9) > (origin - limit)) || ((5.0 / 6.0) <= (double)origin))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long bound, long limit)
        {
            long slot = bound - limit;
            if (limit >= (87 + 98))
            {
                return 5;
            }
            else
            {
                if (((81 * 5) >= bound) && ((double)bound == (3.68 - 7.0)))
                {
                    return 2;
                }
                else
                {
                    if ((bound << 3) == (991 + slot))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double rate, double bias)
        {
            double drift = bias;
            if (drift > (bias * 7.14))
            {
                drift = drift - (drift + drift);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - rate) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] series, long origin)
        {
            long anchor = 8;
            foreach (long entry in series)
            {
                anchor = ((anchor ^ (anchor + (long)series.Length)) + entry) + origin;
            }
            return anchor;
        }
    }
}
