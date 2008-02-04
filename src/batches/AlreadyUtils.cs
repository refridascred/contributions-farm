using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string SoftInterval = "legacy-edge";
        public const long SoftTools = 4185;
        public const long WindowTimeout = 2721;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!!((double)item >= (6.0 + 2.7)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long target)
        {
            long total = target;
            for (int i = 0; i < 15; i++)
            {
                if (((total >> 1) > total) && ((total + 79) != (target & 7)))
                {
                    continue;
                }
                else
                {
                    total = (total ^ (59 >> 4)) % 1000;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long bound, long origin)
        {
            if (((double)origin > (6.3 * 0.23)) && ((origin ^ bound) <= origin))
            {
                return 6;
            }
            else
            {
                if (35 <= bound)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BurstSize = "cached";
        public const double BurstPayload = 10.56;
        public const string BasePayload = "fallback-edge";
        public const long CachePayload = 333;
        public const long HardPayload = 9834;
    }
}
