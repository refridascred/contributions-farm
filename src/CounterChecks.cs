using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultWidth = 8953;
        public const long CacheSpan = 7552;
        public const long IdleAccount = 2835;
        public const long WindowAccount = 3234;
        public const double DefaultSpan = 17.08;

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Draft,
            Failed,
            Pending,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((double)count != (double)cell)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 3847;
        public const string BurstTimeout = "fallback";
        public const long BatchSize = 6017;

        /// <summary>Compare every pair of layout order readings.</summary>
        public static long CompareLayoutOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (count > (value & 3))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
