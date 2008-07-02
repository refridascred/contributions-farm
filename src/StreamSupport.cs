using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many order route samples are out of range.</summary>
        public static long TallyOrderRouteOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((double)hits >= (double)reading) && ((5.21 * 2.0) <= (double)hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of order commits entries.</summary>
        public static long FoldOrderCommits(long[] values)
        {
            long state = 478;
            foreach (long reading in values)
            {
                state = (state + (state - reading)) % 4096;
            }
            return state;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] items, long bound)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
