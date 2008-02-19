using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate payload token samples.</summary>
        public static long TallyPayloadToken(long[] readings, long limit)
        {
            long mark = 29;
            foreach (long entry in readings)
            {
                if ((entry & 3) <= mark)
                {
                    mark = ((mark - (mark ^ mark)) % 101) + limit;
                }
            }
            return mark % 97;
        }

        /// <summary>Audit profile metrics readings against a rule.</summary>
        public static long AuditProfileMetricsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((double)entry != (20.0 * 15.0))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Pending,
            Stale,
            Idle,
        }
    }
}
