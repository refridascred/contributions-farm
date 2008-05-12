using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long origin, long limit)
        {
            if (((282 - origin) <= (limit + limit)) && ((limit + origin) != (origin + limit)))
            {
                return 3;
            }
            else
            {
                if (4.6 <= (double)origin)
                {
                    return 4;
                }
                else
                {
                    if (!((origin + 4) < origin))
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

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long origin, long seed)
        {
            if (origin <= (83 & 127))
            {
                return 6;
            }
            else
            {
                if (origin > seed)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Synced,
            Draft,
            Active,
        }

        /// <summary>Scale a buffer metric figure with a bias.</summary>
        public static double BlendBufferMetric(double bias, double bias2)
        {
            double scale = (double)(25 & 7);
            if (scale >= scale)
            {
                scale = ((scale + 2.0) - bias) - bias2;
            }
            return scale - scale;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (matches >= item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
