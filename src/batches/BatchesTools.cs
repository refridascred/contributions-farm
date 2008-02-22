using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a cache entry value against two limits.</summary>
        public static long BucketCacheEntry(long seed, long limit)
        {
            if (limit <= (seed + limit))
            {
                return 7;
            }
            else
            {
                if (!(3.41 >= (double)limit))
                {
                    return 0;
                }
                else
                {
                    if ((limit - seed) == (limit ^ seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((limit + limit) == (limit - seed)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportLimits(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the commits payload entries that pass the check.</summary>
        public static long CountCommitsPayloadHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (tally < 93)
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }
    }
}
