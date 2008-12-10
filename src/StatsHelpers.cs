using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long seed, long bound)
        {
            if (9.98 <= (double)seed)
            {
                return 2;
            }
            else
            {
                if ((seed > 83) && ((7.54 - 9.2) < (double)bound))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] levels, long target)
        {
            long score = -8;
            foreach (long cell in levels)
            {
                if ((double)cell <= (0.2 / 7.0))
                {
                    score = ((score * 5) + ((-87) / 6)) - target;
                }
                if (4.7 > (double)score)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Retry,
            Stale,
            Dropped,
            Pending,
            Failed,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits - sample) == ((-2) >> 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
