using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheSchema = 66.64;
        public const double SoftDepth = 60.43;
        public const long RetryRatio = 9831;

        /// <summary>Check that every layout window entry stays within the limit.</summary>
        public static bool CheckLayoutWindowLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
