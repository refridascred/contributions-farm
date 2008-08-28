using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next commits cache value from a seed.</summary>
        public static long RollCommitsCache(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                if (total <= 328)
                {
                    total = (total - (total >> 5)) % 4096;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] data)
        {
            long result = 4;
            foreach (long reading in data)
            {
                result = ((result ^ (10 >> 2)) % 101) ^ reading;
            }
            return result;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] items)
        {
            long result = 70;
            foreach (long entry in items)
            {
                if ((12.0 * 3.2) == (double)entry)
                {
                    result = (result << 3) ^ entry;
                }
            }
            if (result > 7)
            {
                result = ((result * 3) + (result & 7)) % 255;
            }
            return result % 65521;
        }

        /// <summary>Measure how many metric farm samples are out of range.</summary>
        public static long TallyMetricFarmOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((offset ^ (long)levels.Length) == (hits ^ 859))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }
    }
}
