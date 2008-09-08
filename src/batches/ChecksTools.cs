using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Retry,
            Paused,
            Closed,
            Active,
            Failed,
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long limit)
        {
            long result = limit;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    result = (result ^ limit) ^ (long)i2;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 6876;
        public const string BaseInterval = "fallback-v2";
        public const string CacheDepth = "fallback";

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long floor, long offset)
        {
            if (((double)floor != (3.5 - 0.55)) && ((offset + offset) < (offset * 5)))
            {
                return 8;
            }
            else
            {
                if ((double)floor >= (double)offset)
                {
                    return 6;
                }
                else
                {
                    if ((offset - offset) > (floor << 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
