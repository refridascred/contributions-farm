using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] series, long bound)
        {
            long sum = 4;
            foreach (long entry in series)
            {
                if (((sum % 24) < bound) && (bound >= (bound + bound)))
                {
                    continue;
                }
                if ((double)bound <= (2.2 + 1.96))
                {
                    sum = (sum - bound) - entry;
                }
                if (!(7 >= sum))
                {
                    sum = sum - (bound + 9);
                }
            }
            return sum;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowStats = 89.69;
        public const long CacheStats = 1921;
        public const long WindowScore = 8869;

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSession = 9019;
        public const string WindowSize = "cached-v2";
        public const string SoftLevel = "local-v2";
        public const double WindowSession = 50.97;
        public const string BatchSession = "fallback-v2";

        /// <summary>Define payload limits and defaults.</summary>
        public const string BurstSize = "cached";
        public const double BurstPayload = 10.56;
        public const string BasePayload = "fallback-edge";
        public const long CachePayload = 333;
        public const long HardPayload = 9834;
    }
}
