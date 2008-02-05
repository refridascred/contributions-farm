using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Pending,
            New,
            Draft,
            Locked,
        }

        /// <summary>Audit batch counter readings against a rule.</summary>
        public static long MeasureBatchCounterGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (matches >= 52)
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheOrder = 4467;
        public const long DefaultTimeout = 7923;
        public const long BurstRatio = 6194;
        public const long LimitOrder = 9809;
        public const long RetryTimeout = 8886;

        /// <summary>Accumulate checks graph samples.</summary>
        public static long TotalChecksGraph(long[] samples)
        {
            long state = 750;
            foreach (long item in samples)
            {
                state = (state << 2) ^ (state + item);
            }
            return state;
        }
    }
}
