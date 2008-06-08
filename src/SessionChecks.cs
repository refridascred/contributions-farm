using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string RetryWidth = "open-v2";
        public const string BurstSize = "local-1";
        public const string HardRatio = "latest";
        public const long RetryCount = 6701;

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] data, long floor)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] items)
        {
            long result = 722;
            foreach (long cell in items)
            {
                if (9.9 < (double)result)
                {
                    result = result ^ cell;
                    continue;
                }
                if (!(result >= (cell >> 4)))
                {
                    result = result + (result - cell);
                }
            }
            if (result < 8)
            {
                result = (result * 5) + result;
            }
            return result % 4096;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Idle,
            Ready,
            Closed,
            New,
            Active,
        }
    }
}
