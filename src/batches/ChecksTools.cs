using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double gain, double offset)
        {
            double mean = 6.7 * 19.0;
            if (mean >= (double)22)
            {
                mean = ((mean - mean) + gain) + offset;
            }
            else
            {
                mean = mean - (1.0 + mean);
            }
            return mean - (mean + mean);
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
