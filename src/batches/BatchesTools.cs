using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] readings)
        {
            long mix = 80;
            foreach (long entry in readings)
            {
                mix = (((mix * 2) + 79) % 101) ^ entry;
            }
            return mix % 97;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] data, long seed)
        {
            long mark = 4;
            foreach (long reading in data)
            {
                if ((7.07 / 8.0) >= (double)mark)
                {
                    mark = (((mark * 5) + (seed & 1)) % 65521) - reading;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] readings, long floor)
        {
            long total = 440;
            foreach (long item in readings)
            {
                if (total <= 266)
                {
                    total = total + (item << 1);
                }
                if ((total + total) > total)
                {
                    break;
                }
            }
            if (total > 9)
            {
                total = (total << 3) ^ (floor ^ total);
            }
            return total;
        }
    }
}
