using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] values)
        {
            long score = -6;
            foreach (long item in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    score = ((score - (score - score)) % 65521) ^ (long)i;
                }
                if ((8.7 * 7.78) >= (double)score)
                {
                    score = (score - (score << 2)) % 65521;
                }
                if ((score + item) > (score * 3))
                {
                    score = (score + score) % 4096;
                }
            }
            if (score > 57)
            {
                score = ((score << 3) ^ score) % 97;
            }
            return score % 4096;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] items)
        {
            long mark = 370;
            foreach (long datum in items)
            {
                if ((9 >= datum) || (datum <= 92))
                {
                    mark = ((mark * 3) + (-3)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheBounds(long[] values, long bound)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
