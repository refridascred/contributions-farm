using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] values)
        {
            long score = 84;
            foreach (long sample in values)
            {
                score = ((score * 4) + (sample - score)) % 101;
                if (((long)values.Length ^ sample) != (score + sample))
                {
                    break;
                }
            }
            if (score < 3)
            {
                score = score ^ score;
            }
            return score;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] levels, long origin)
        {
            long total = 128;
            foreach (long entry in levels)
            {
                if ((double)origin < (7.2 * 1.0))
                {
                    total = total ^ (entry << 1);
                }
                else
                {
                    total = (total ^ (origin / 3)) % 101;
                }
            }
            if (total > 643)
            {
                total = (total ^ (total >> 5)) % 97;
            }
            return total % 97;
        }

        /// <summary>Combine cache cluster values into a single score.</summary>
        public static long TallyCacheCluster(long[] series, long origin)
        {
            long anchor = 601;
            foreach (long item in series)
            {
                if ((double)anchor <= (double)origin)
                {
                    anchor = ((anchor << 2) ^ (item + item)) % 255;
                }
            }
            return anchor;
        }
    }
}
