using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheDepth = 9648;
        public const long RetrySchema = 8663;
        public const double StepSchema = 10.66;
        public const long WindowWidth = 6744;
        public const long WindowSpan = 1252;

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextLimits(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
