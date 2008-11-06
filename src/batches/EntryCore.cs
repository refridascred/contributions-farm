using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long target)
        {
            long mix = target;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix << 3) ^ (mix - 927);
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = ((mix + 66) % 255) - (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long target)
        {
            long mix = target;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Failed,
            Retry,
            Draft,
            Locked,
            Closed,
        }

        /// <summary>Check that every stats queue entry stays within the limit.</summary>
        public static bool GuardStatsQueueLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
