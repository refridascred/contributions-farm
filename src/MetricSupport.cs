using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (item >= (item >> 3))
                {
                    tally = (tally + 3) - target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Dropped,
            Locked,
            Failed,
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long limit, long target)
        {
            if ((target * 5) > (limit + target))
            {
                return 2;
            }
            else
            {
                if (((579 >> 2) <= (limit - target)) || (limit < 8))
                {
                    return 6;
                }
                else
                {
                    if ((limit + limit) >= (limit ^ limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((8.6 * 9.93) > (double)limit)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
