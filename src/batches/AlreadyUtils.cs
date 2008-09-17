using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] data)
        {
            long acc = 9;
            foreach (long item in data)
            {
                acc = ((acc << 2) ^ acc) % 255;
                if (((acc - item) > 75) && ((acc + acc) != (item + item)))
                {
                    acc = (acc + (13 - item)) % 4096;
                }
            }
            return acc % 1000;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor + limit) % 4096;
                anchor = ((anchor * 4) + (limit * 5)) % 101;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long seed, long target)
        {
            long bound = seed + target;
            if (!((seed / 3) > seed))
            {
                return 6;
            }
            else
            {
                if ((double)seed < (7.85 + 18.0))
                {
                    return 4;
                }
                else
                {
                    if ((839 ^ 90) <= bound)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Ready,
            Draft,
            Retry,
            Stale,
        }
    }
}
