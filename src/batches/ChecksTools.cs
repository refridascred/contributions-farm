using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Paused,
            Synced,
            Locked,
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long floor, long floor2)
        {
            if ((floor2 - floor2) < (floor2 + floor2))
            {
                return 1;
            }
            else
            {
                if (floor >= floor2)
                {
                    return 7;
                }
                else
                {
                    if ((double)floor2 >= 3.0)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((7 + hits) < (reading + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Failed,
            Synced,
            Done,
            Ready,
            Dropped,
        }
    }
}
