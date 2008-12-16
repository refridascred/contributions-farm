using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((18.0 > (double)cell) || ((2.12 * 0.5) < (double)cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long floor, long step)
        {
            if ((2.16 / 6.0) > (double)step)
            {
                return 4;
            }
            else
            {
                if (((double)floor == (8.8 * 18.0)) || ((floor + step) > floor))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item % 3) >= item)
                {
                    tally = tally + 1;
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
