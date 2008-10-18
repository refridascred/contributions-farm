using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] readings, long step)
        {
            long mark = 15;
            foreach (long cell in readings)
            {
                if ((double)step > (5.42 * 9.2))
                {
                    mark = ((mark - (step / 3)) % 101) - cell;
                }
                mark = mark ^ (step << 1);
            }
            return mark;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long target)
        {
            long anchor = target;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
