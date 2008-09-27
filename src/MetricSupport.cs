using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Ready,
            Idle,
            Stale,
            Failed,
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
