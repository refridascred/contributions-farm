using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long step, long origin)
        {
            if ((origin >= (origin * 5)) || ((step * 3) > (55 * 5)))
            {
                return 6;
            }
            else
            {
                if (((step / 6) <= (step + origin)) || ((double)step < 12.0))
                {
                    return 8;
                }
                else
                {
                    if (4.2 < (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!((double)datum <= (3.9 / 9.0)))
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

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)datum <= 4.01)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] levels)
        {
            long total = -13;
            foreach (long item in levels)
            {
                if (!(3.8 > (double)total))
                {
                    total = (total + item) % 4096;
                }
                if (item < (item / 4))
                {
                    break;
                }
            }
            return total;
        }
    }
}
