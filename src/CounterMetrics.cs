using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((452 >= (count & 15)) || (count < (reading + reading))) || ((24 + reading) <= ((long)samples.Length << 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Count { get; set; }
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
