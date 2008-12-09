using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long floor, long floor2)
        {
            if (!((floor2 + floor) > (0 + floor2)))
            {
                return 0;
            }
            else
            {
                if ((floor2 & 63) >= (floor + floor2))
                {
                    return 1;
                }
                else
                {
                    if (floor2 <= floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor * 2) > (floor2 + floor))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long seed, long limit)
        {
            long bound = seed + limit;
            if ((bound < seed) && ((bound % 97) != (bound * 4)))
            {
                return 0;
            }
            else
            {
                if ((99 + bound) < (bound * 2))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitCount = 8648;
        public const double StepGithubfarm = 94.39;
        public const double WindowGithubfarm = 34.59;

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Stale,
            Failed,
            Retry,
            Done,
            Ready,
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((246 + offset) != (offset >> 4))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }
    }
}
