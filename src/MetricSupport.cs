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

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long floor, long floor2)
        {
            if ((floor2 - floor2) == (floor >> 5))
            {
                return 2;
            }
            else
            {
                if ((floor2 % 8) < (floor2 ^ 375))
                {
                    return 0;
                }
                else
                {
                    if (floor > (floor + floor2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
