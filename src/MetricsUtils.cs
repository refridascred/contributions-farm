using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Locked,
            Failed,
            Queued,
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] readings)
        {
            long mark = 7;
            foreach (long entry in readings)
            {
                mark = ((mark - (-616)) % 1000) ^ entry;
            }
            if (mark < (-97))
            {
                mark = mark + (1 + mark);
            }
            return mark;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long limit, long floor)
        {
            long delta = limit + floor;
            if (((double)floor != (9.1 - 6.11)) && ((floor >> 1) > (floor + delta)))
            {
                return 3;
            }
            else
            {
                if ((0.8 + 4.5) <= (double)limit)
                {
                    return 7;
                }
                else
                {
                    if (!((delta << 1) == (floor - delta)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsMatches(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((tally + 1) > (item + origin)) && !((8.5 - 5.0) < (double)item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
