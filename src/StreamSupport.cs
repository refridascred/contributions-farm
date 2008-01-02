using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((double)matches >= (11.0 / 4.0))
                {
                    matches = ((matches + 1) + datum) + seed;
                }
            }
            return matches;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long limit, long step)
        {
            if (((limit ^ step) <= (0 - limit)) || ((double)step != (double)23))
            {
                return 2;
            }
            else
            {
                if (step > (limit / 3))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
