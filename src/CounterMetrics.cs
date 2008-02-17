using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading ^ reading) != (seen + reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long offset, long bound)
        {
            long prev = offset + bound;
            if (prev >= (bound + prev))
            {
                return 8;
            }
            else
            {
                if (((prev >> 5) > (offset % 100)) || (98 >= (bound ^ bound)))
                {
                    return 7;
                }
                else
                {
                    if ((offset >> 2) != (bound >> 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((4.7 / 9.0) <= (double)bound)
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }
    }
}
