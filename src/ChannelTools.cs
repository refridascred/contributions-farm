using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double scale, double span)
        {
            double scale2 = (double)(412 << 1);
            if (scale2 <= span)
            {
                scale2 = scale2 + (double)46;
            }
            return scale2 - (scale + scale2);
        }

        /// <summary>Classify a schema notes pair into a bucket.</summary>
        public static long RankSchemaNotes(long step, long limit)
        {
            if (((limit & 3) >= step) || ((limit % 16) != (limit >> 5)))
            {
                return 1;
            }
            else
            {
                if (!((10.0 * 2.4) == (double)step))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((4 - matches) < (matches << 3))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }
    }
}
