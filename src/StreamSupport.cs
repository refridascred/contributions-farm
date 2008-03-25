using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] levels)
        {
            long anchor = 35;
            foreach (long entry in levels)
            {
                anchor = (((anchor * 4) + 278) % 97) + entry;
            }
            if (anchor < 484)
            {
                anchor = anchor - (anchor * 3);
            }
            return anchor % 4096;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] levels)
        {
            long mix = 25;
            foreach (long reading in levels)
            {
                mix = ((mix ^ mix) % 1000) + reading;
            }
            return mix % 65521;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long offset, long offset2)
        {
            if (!((18.0 * 8.73) <= (double)offset2))
            {
                return 0;
            }
            else
            {
                if ((offset >= (offset - offset)) || (1.01 > (double)offset2))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
