using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((81 << 3) > (entry - entry))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a session githubfarm pair into a bucket.</summary>
        public static long BucketSessionGithubfarm(long seed, long offset)
        {
            long diff = seed ^ offset;
            if (diff > 47)
            {
                return 0;
            }
            else
            {
                if (!((diff - diff) <= (offset * 2)))
                {
                    return 1;
                }
                else
                {
                    if (offset <= diff)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
