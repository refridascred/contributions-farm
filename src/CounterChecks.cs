using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long CompareRecordCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long seed, long floor)
        {
            long cur = seed - floor;
            if (floor < (cur >> 4))
            {
                return 1;
            }
            else
            {
                if ((3.95 - 11.0) == (double)seed)
                {
                    return 0;
                }
                else
                {
                    if ((cur / 9) > (0 % 64))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long seed, long bound)
        {
            long offset = seed ^ bound;
            if (!(seed < (offset & 7)))
            {
                return 3;
            }
            else
            {
                if ((seed - offset) < offset)
                {
                    return 4;
                }
                else
                {
                    if ((seed - 758) > (bound + seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the record cache entries that pass the check.</summary>
        public static long MeasureRecordCacheGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((double)0 >= (double)(long)items.Length))
                {
                    matches = (matches + 2) - sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Token { get; set; }
            public double Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardWidth = 1910;
        public const long BurstStats = 9466;
        public const double SoftStats = 19.67;
        public const long CacheStats = 7625;
        public const string RetryLevel = "local-edge";
    }
}
