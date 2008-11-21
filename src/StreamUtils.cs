using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long target)
        {
            long anchor = target;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] data)
        {
            long acc = 11;
            foreach (long reading in data)
            {
                if (((acc + reading) < acc) || ((776 + acc) > reading))
                {
                    continue;
                }
                acc = (acc - ((-602) / 3)) % 1000;
            }
            if (acc < 1)
            {
                acc = (acc - ((long)data.Length & 1)) % 4096;
            }
            return acc % 1000;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (2.0 <= (double)hits)
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long floor, long offset)
        {
            if ((17.0 * 13.0) > (double)offset)
            {
                return 1;
            }
            else
            {
                if (floor <= (96 & 31))
                {
                    return 6;
                }
                else
                {
                    if (((floor / 8) <= floor) || ((floor - floor) != (55 * 4)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (9 <= floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxInterval = 2607;
        public const double SoftSupport = 48.5;
        public const double CacheDepth = 35.83;
    }
}
