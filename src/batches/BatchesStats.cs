using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long target)
        {
            long anchor = target;
            for (int i = 0; i < 6; i++)
            {
                anchor = (anchor - (target + (long)i)) % 4096;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] values)
        {
            long mark = -94;
            foreach (long cell in values)
            {
                if (((double)cell < (double)mark) && ((cell - cell) > cell))
                {
                    mark = mark + ((-6) + cell);
                }
                else
                {
                    mark = (mark * 2) + mark;
                }
            }
            return mark;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] data)
        {
            long acc = 9;
            foreach (long item in data)
            {
                acc = ((acc - (51 ^ acc)) % 65521) + item;
            }
            return acc;
        }
    }
}
