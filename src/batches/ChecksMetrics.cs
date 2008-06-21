using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Label { get; set; } = "";
            public long Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Label { get; set; }
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits > (value >> 5)) || !((floor - floor) <= (54 >> 1)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many support tools samples are out of range.</summary>
        public static long TallySupportToolsGaps(long[] items, long limit)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((count * 3) <= (limit - cell)) || ((limit % 2) == (cell << 1)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((3.0 * 16.0) <= (double)item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
