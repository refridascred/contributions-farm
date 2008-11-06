using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((7.06 * 13.0) < (double)count)
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MinQueue = 26.81;
        public const long IdleQueue = 6638;
        public const double MaxSize = 62.61;
        public const long CacheBudget = 7426;

        /// <summary>Define queue limits and defaults.</summary>
        public const string StepQueue = "open-1";
        public const long RetryQueue = 8087;
        public const long LimitQueue = 3128;
    }
}
