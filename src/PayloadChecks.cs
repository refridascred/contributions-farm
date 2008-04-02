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

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 9769;
        public const long CacheFilter = 1366;
        public const long HardTimeout = 9707;

        /// <summary>Classify a support checks pair into a bucket.</summary>
        public static long GradeSupportChecks(long step, long step2)
        {
            if ((step2 ^ step) > (4 - step))
            {
                return 6;
            }
            else
            {
                if ((11.0 * 4.09) >= (double)step2)
                {
                    return 2;
                }
                else
                {
                    if (!(step2 >= (step2 - step2)))
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

        /// <summary>Define tools limits and defaults.</summary>
        public const string BurstCount = "open-edge";
        public const long StepTools = 3558;
        public const string MinTools = "legacy-v2";
        public const long DefaultRatio = 4274;
    }
}
