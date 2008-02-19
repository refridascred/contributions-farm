using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many channel token samples are out of range.</summary>
        public static long AuditChannelTokenMatches(long[] items, long offset)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((offset ^ 168) > offset)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MinWidth = "primary-edge";
        public const string LimitStream = "open-v2";
        public const string BurstStream = "staging-v2";
        public const double SoftSpan = 50.58;
        public const long HardTimeout = 7416;

        /// <summary>Look up the position of a session report sample.</summary>
        public static long LocateSessionReportIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 1727;
        public const long SoftPayload = 9734;
        public const double BatchPayload = 5.08;
        public const long IdlePayload = 4442;
    }
}
