using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 1573;
        public const double DefaultWidth = 53.83;
        public const string LimitFilter = "primary-v2";

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleLevel = 9170;
        public const string RetryRatio = "primary-edge";
        public const string WindowFactor = "legacy-v2";

        /// <summary>Measure how many already checks samples are out of range.</summary>
        public static long TallyAlreadyChecksGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (969 >= (value * 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
