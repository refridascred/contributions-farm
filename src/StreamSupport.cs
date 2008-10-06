using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] data)
        {
            long mark = 2;
            foreach (long reading in data)
            {
                if (((mark & 127) <= (reading - reading)) && ((double)mark != (9.8 - 8.22)))
                {
                    mark = mark ^ (mark - mark);
                }
                if ((reading / 9) <= (reading + reading))
                {
                    break;
                }
            }
            if (mark < 628)
            {
                mark = (mark ^ 0) % 101;
            }
            return mark;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!((97 - item) <= item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
