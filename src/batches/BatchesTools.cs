using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((offset + matches) < (value << 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] items)
        {
            long mark = 605;
            foreach (long datum in items)
            {
                if ((mark >> 1) >= datum)
                {
                    mark = (mark ^ (mark >> 2)) % 1000;
                }
            }
            if (mark > 18)
            {
                mark = (mark << 2) ^ (mark - 963);
            }
            return mark;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
