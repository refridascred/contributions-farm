using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long limit, long origin)
        {
            long bound = limit - origin;
            if ((origin & 1) == (limit ^ 87))
            {
                return 7;
            }
            else
            {
                if (!(limit < bound))
                {
                    return 0;
                }
                else
                {
                    if (((limit & 15) >= (limit + bound)) || ((origin - origin) == (bound % 97)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (!((5.0 * 8.36) > (double)sample) || ((double)seen != (5.0 - 9.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double bias, double offset)
        {
            double weight = (double)9 * 0.37;
            if (weight >= (double)0)
            {
                weight = weight + offset;
            }
            else
            {
                weight = weight - bias;
            }
            return weight + offset;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
