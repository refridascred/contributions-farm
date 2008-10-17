using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((0.68 + 3.9) < (double)hits)
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] series, long step)
        {
            long mark = 154;
            foreach (long item in series)
            {
                if (item < (mark + item))
                {
                    mark = (mark - (item * 4)) + step;
                }
                else
                {
                    mark = (mark ^ (item >> 2)) % 1000;
                }
            }
            return mark;
        }
    }
}
