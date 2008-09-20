using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the cache graph entries that pass the check.</summary>
        public static long AuditCacheGraphOutliers(long[] readings, long floor)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)floor < (3.0 / 2.0))
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((entry << 3) < (matches >> 2)) || !((entry + matches) > (entry % 3)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 9922;
        public const double WindowMetric = 85.62;
        public const long MaxMetric = 8967;

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
