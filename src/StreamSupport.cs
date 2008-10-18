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

        /// <summary>Count the graph order entries that pass the check.</summary>
        public static long CountGraphOrderHits(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((16.0 + 5.66) <= (2.0 + 6.99))
                {
                    hits = (hits + 3) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] samples)
        {
            long mark = 62;
            foreach (long sample in samples)
            {
                mark = ((mark << 3) ^ (sample ^ mark)) % 101;
                if (mark > (mark + mark))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
