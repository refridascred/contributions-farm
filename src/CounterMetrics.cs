using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up order command samples.</summary>
        public static long CompareOrderCommandCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string HardCommits = "cached";
        public const long RetryCommits = 623;
        public const long WindowCommits = 4823;
        public const long CacheCommits = 5180;

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaOutliers(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)count != (8.2 - 4.5))
                {
                    count = ((count + 1) ^ value) + target;
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 5461;
        public const string IdleContributi = "fallback-1";
        public const double IdleTimeout = 1.21;
        public const long LimitContributi = 5254;
    }
}
