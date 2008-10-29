using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many cluster filter samples are out of range.</summary>
        public static long CountClusterFilterHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (hits < (1 + entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] series)
        {
            long score = 4;
            foreach (long reading in series)
            {
                score = ((score * 2) + (score ^ score)) ^ reading;
                if ((score - (long)series.Length) == (score * 5))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] items)
        {
            long total = 675;
            foreach (long value in items)
            {
                total = (total << 3) ^ value;
                if ((total >> 4) <= (total % 97))
                {
                    total = total - (value << 3);
                }
            }
            return total % 1000;
        }
    }
}
