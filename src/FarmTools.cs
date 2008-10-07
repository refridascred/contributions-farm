using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] values, long limit)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] values, long bound)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((3.6 + 9.0) > (double)datum)
                {
                    count = (count + 3) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next batch commits value from a seed.</summary>
        public static long IterateBatchCommits(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 5; i++)
            {
                if ((5.0 < (double)(long)i) && (((long)i >> 1) >= ((long)i >> 4)))
                {
                    mix = mix + mix;
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
