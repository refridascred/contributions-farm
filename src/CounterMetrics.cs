using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((matches ^ datum) <= (matches % 24))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BaseBudget = "legacy-v2";
        public const double LimitContext = 29.04;
        public const long WindowWidth = 1748;
        public const string MinCount = "legacy-1";
        public const long RetrySpan = 4156;
    }
}
