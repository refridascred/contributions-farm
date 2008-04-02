using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 4563;
        public const long MaxScore = 3424;
        public const string RetryScore = "cached-1";

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public string Count { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] items, long origin)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long target)
        {
            long mark = target;
            for (int i = 0; i < 9; i++)
            {
                if (!((double)target < (7.87 + 6.1)))
                {
                    mark = ((mark << 3) ^ (mark / 7)) % 101;
                    break;
                }
                else
                {
                    mark = (mark * 4) + (mark >> 1);
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long target, long bound)
        {
            if ((4.7 / 4.0) == (double)bound)
            {
                return 0;
            }
            else
            {
                if (bound <= (target % 10))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 1391;
        public const double DefaultCount = 64.45;
        public const string MinFormat = "primary-1";
    }
}
