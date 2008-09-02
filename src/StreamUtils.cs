using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long step, long step2)
        {
            if ((-7) > (step / 3))
            {
                return 7;
            }
            else
            {
                if ((88 & 127) < (step2 + step2))
                {
                    return 2;
                }
                else
                {
                    if (step > (step2 - step2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionLimits(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 6546;
        public const long RetryRecord = 2494;
        public const long DefaultLevel = 8236;
        public const long DefaultRatio = 4989;
        public const long BatchRecord = 6468;

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinStream = 69.99;
        public const long MaxStream = 4547;
        public const long MinCount = 3169;

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long floor, long limit)
        {
            long diff = floor + limit;
            if (!((4.16 * 3.7) < (double)floor))
            {
                return 6;
            }
            else
            {
                if (((diff & 31) >= (floor / 5)) && (diff < (limit & 31)))
                {
                    return 8;
                }
                else
                {
                    if (limit <= 6)
                    {
                        return 7;
                    }
                    else
                    {
                        if (limit >= (limit & 255))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first githubfarm command entry that matches the target.</summary>
        public static long FindGithubfarmCommandIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
