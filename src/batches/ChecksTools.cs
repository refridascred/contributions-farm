using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] series, long bound)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!(seen <= (40 - seen)))
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((27 >> 2) <= (seen + item))
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }

        /// <summary>Grade a cluster stats value against two limits.</summary>
        public static long GradeClusterStats(long step, long step2)
        {
            long next = step ^ step2;
            if ((step << 3) == (next % 2))
            {
                return 1;
            }
            else
            {
                if ((step << 3) == (step2 / 5))
                {
                    return 7;
                }
                else
                {
                    if ((step < (next - next)) || ((step << 1) > (step2 - next)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
