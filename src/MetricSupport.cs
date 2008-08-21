using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a contributi already value against two limits.</summary>
        public static long RankContributiAlready(long seed, long bound)
        {
            if (!((15.0 * 11.0) == (double)bound))
            {
                return 8;
            }
            else
            {
                if ((double)seed > (6.7 + 0.1))
                {
                    return 7;
                }
                else
                {
                    if (bound <= (bound - seed))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Failed,
            Ready,
            Retry,
            Done,
        }
    }
}
