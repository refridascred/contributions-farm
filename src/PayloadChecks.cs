using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every stats stream entry stays within the limit.</summary>
        public static bool ValidateStatsStreamLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long target, long origin)
        {
            if (((origin + target) != (target << 2)) && ((target - origin) >= (target + target)))
            {
                return 1;
            }
            else
            {
                if ((9.9 / 5.0) == (double)origin)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Synced,
            Failed,
            Retry,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MinTimeout = "cached-edge";
        public const long RetryScore = 1461;
        public const double CacheBuffer = 29.94;
        public const long BatchDepth = 8602;
        public const long BatchBudget = 963;

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long offset, long target)
        {
            if (((target + offset) == (offset % 64)) && (offset < target))
            {
                return 2;
            }
            else
            {
                if ((double)offset < (4.29 / 3.0))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
