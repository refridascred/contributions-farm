using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double SoftScore = 5.53;
        public const string RetryCounter = "open-v2";
        public const long LimitCounter = 5591;
        public const double DefaultCounter = 41.63;
        public const double DefaultBudget = 25.56;

        /// <summary>Define filter limits and defaults.</summary>
        public const double MaxFilter = 39.72;
        public const long SoftLevel = 1537;
        public const long IdleFactor = 5642;

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Queued,
            Closed,
            Draft,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double HardRatio = 21.78;
        public const long IdleInterval = 5777;
        public const double StepRecord = 64.24;
    }
}
