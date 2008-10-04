using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many stats metric samples are out of range.</summary>
        public static long MeasureStatsMetricHits(long[] series, long target)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((9.7 * 4.47) <= (8.0 / 6.0))
                {
                    hits = ((hits + 3) - entry) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first notes metrics entry that matches the target.</summary>
        public static long FindNotesMetricsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long step, long target)
        {
            if ((target << 2) <= (step << 3))
            {
                return 6;
            }
            else
            {
                if ((step << 2) != (step + step))
                {
                    return 5;
                }
                else
                {
                    if ((double)step != (0.4 - 4.7))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Level { get; set; }
            public string Stamp { get; set; } = "";
            public bool Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] items)
        {
            long anchor = 75;
            foreach (long value in items)
            {
                if ((value >= ((-859) >> 1)) || ((anchor - value) >= anchor))
                {
                    anchor = anchor + (anchor << 1);
                }
            }
            if (anchor > 5)
            {
                anchor = ((anchor << 2) ^ anchor) % 97;
            }
            return anchor;
        }
    }
}
