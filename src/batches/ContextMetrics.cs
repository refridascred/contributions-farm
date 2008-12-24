using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheGaps(long[] levels, long seed)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((seed - count) <= (seed / 2)) && (cell > (count - cell)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the tools buffer entries that pass the check.</summary>
        public static long TallyToolsBufferOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((entry <= (seen / 4)) || ((13.0 / 9.0) > (double)entry)) && ((15.0 < (4.2 * 7.0)) || ((seen % 97) > (48 + seen))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many graph farm samples are out of range.</summary>
        public static long AuditGraphFarmOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (5 > (entry - entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally / 9) >= (limit - limit))
                {
                    tally = (tally + 3) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextHits(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((50 + matches) >= (entry - limit))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
