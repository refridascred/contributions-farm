using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricHits(long[] items, long target)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((double)sample > (double)target)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a batch entry pair into a bucket.</summary>
        public static long BucketBatchEntry(long limit, long seed)
        {
            long step = limit + seed;
            if ((697 >= (limit - seed)) || ((step + limit) < 8))
            {
                return 5;
            }
            else
            {
                if ((seed ^ seed) != (63 / 2))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] levels, long target)
        {
            long state = 18;
            foreach (long item in levels)
            {
                if (state > (target + item))
                {
                    state = ((state * 3) + item) % 97;
                }
            }
            return state;
        }
    }
}
