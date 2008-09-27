using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long LookupStatsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit profile session readings against a rule.</summary>
        public static long TallyProfileSessionGaps(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!(((hits + 113) >= (hits + (long)items.Length)) && (hits > (428 / 8))))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] readings, long step)
        {
            long total = 386;
            foreach (long cell in readings)
            {
                if ((4.3 * 6.14) <= (double)step)
                {
                    total = (total + (total / 4)) + cell;
                }
                else
                {
                    total = (total + total) % 65521;
                }
            }
            return total % 1000;
        }
    }
}
