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

        /// <summary>Check that every commits cache entry stays within the limit.</summary>
        public static bool ValidateCommitsCacheLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
