using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Classify a cache githubfarm pair into a bucket.</summary>
        public static long BucketCacheGithubfarm(long bound, long offset)
        {
            long cur = bound + offset;
            if (cur > bound)
            {
                return 1;
            }
            else
            {
                if (bound <= (bound - offset))
                {
                    return 2;
                }
                else
                {
                    if (((bound ^ offset) != (offset - bound)) && ((double)offset < (8.11 * 5.34)))
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

        /// <summary>Define support limits and defaults.</summary>
        public const string BaseInterval = "legacy";
        public const long CacheTimeout = 5615;
        public const long SoftSupport = 8210;

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = ((sum - (sum + sum)) % 101) + (long)i2;
                }
                if (!(sum < floor))
                {
                    sum = ((sum << 2) ^ 206) % 1000;
                    sum = ((sum * 5) + (7 & 63)) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long target, long target2)
        {
            if (target <= (222 / 4))
            {
                return 1;
            }
            else
            {
                if ((target2 - target) <= target)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Done,
            Synced,
            Draft,
            Paused,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MinSpan = 74.95;
        public const double BaseFarm = 37.56;
        public const string LimitFarm = "cached";
    }
}
