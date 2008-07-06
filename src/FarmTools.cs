using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] items)
        {
            long acc = 38;
            foreach (long reading in items)
            {
                acc = (acc - (acc + acc)) % 4096;
                if ((reading ^ acc) > reading)
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (93 < (bound >> 5))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long step, long step2)
        {
            if ((step ^ step2) >= (step & 31))
            {
                return 8;
            }
            else
            {
                if ((double)step == (5.1 - 8.0))
                {
                    return 0;
                }
                else
                {
                    if ((step2 + step2) != (step2 & 31))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
