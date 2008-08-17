using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleDepth = 3254;
        public const long BatchTimeout = 8278;
        public const long BurstRecord = 7587;
        public const long BaseRatio = 9429;
        public const double CacheSpan = 71.54;

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Queued,
            Stale,
            New,
            Retry,
        }

        /// <summary>Check that every batch stream entry stays within the limit.</summary>
        public static bool GuardBatchStreamRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountLimits(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
