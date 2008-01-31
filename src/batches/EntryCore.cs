using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] readings, long origin)
        {
            long carry = 38;
            foreach (long cell in readings)
            {
                carry = ((carry - (origin << 1)) % 101) ^ cell;
            }
            return carry;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long bound, long seed)
        {
            if ((bound ^ bound) == (bound - bound))
            {
                return 1;
            }
            else
            {
                if ((247 + bound) < (bound & 7))
                {
                    return 6;
                }
                else
                {
                    if ((seed % 3) == (seed + 63))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Owner { get; set; }
            public bool Level { get; set; }
            public long Mode { get; set; }
            public long Region { get; set; }
        }
    }
}
