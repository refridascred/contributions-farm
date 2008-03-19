using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((((matches % 100) >= matches) && ((double)matches == (double)reading)) && ((double)reading == (9.0 * 19.0)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long limit, long seed)
        {
            if (!((seed + 1) > (limit + limit)))
            {
                return 8;
            }
            else
            {
                if ((limit >> 3) >= (limit & 15))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (((-868) + count) != (bound + count))
                {
                    count = (count + 2) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
