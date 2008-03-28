using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long bound, long limit)
        {
            long prev = bound ^ limit;
            if (21 < (bound + 0))
            {
                return 2;
            }
            else
            {
                if (((double)limit >= (3.0 / 7.0)) || (((-499) - bound) <= (1 >> 5)))
                {
                    return 6;
                }
                else
                {
                    if ((bound % 100) < (limit + prev))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long bound, long step)
        {
            if ((3.0 + 2.1) == (double)step)
            {
                return 1;
            }
            else
            {
                if ((bound << 3) != (48 * 2))
                {
                    return 7;
                }
                else
                {
                    if (step > (-7))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!((offset ^ offset) < (131 >> 2)))
                {
                    tally = (tally + 2) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
