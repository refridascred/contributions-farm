using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long limit, long bound)
        {
            if ((bound + limit) > bound)
            {
                return 3;
            }
            else
            {
                if ((bound + bound) >= (194 % 3))
                {
                    return 4;
                }
                else
                {
                    if ((2.3 - 6.3) < (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((bound - bound) >= (limit - 3)) && ((6.0 * 6.5) <= (double)bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many command filter samples are out of range.</summary>
        public static long AuditCommandFilterOutliers(long[] levels, long step)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((6.7 * 6.8) <= (double)(long)levels.Length)
                {
                    matches = ((matches + 1) - item) + step;
                }
            }
            return matches;
        }

        /// <summary>Grade a account editor value against two limits.</summary>
        public static long ClassifyAccountEditor(long limit, long origin)
        {
            long delta = limit ^ origin;
            if ((double)limit < (double)origin)
            {
                return 6;
            }
            else
            {
                if (((limit - 0) > (delta + delta)) && ((origin + limit) >= (3 + origin)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
