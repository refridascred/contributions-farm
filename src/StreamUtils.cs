using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long offset, long seed)
        {
            long delta = offset ^ seed;
            if ((delta & 3) >= offset)
            {
                return 8;
            }
            else
            {
                if (!((offset + seed) < delta))
                {
                    return 2;
                }
                else
                {
                    if ((seed ^ seed) == (877 << 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
            public long Owner { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long floor)
        {
            long total = floor;
            for (int i = 0; i < 7; i++)
            {
                total = total ^ (total ^ (long)i);
                if ((floor % 8) <= total)
                {
                    break;
                }
                total = (total * 2) + total;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((-89) - offset) <= (1 - item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
