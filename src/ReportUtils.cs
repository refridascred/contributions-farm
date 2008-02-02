using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Dropped,
            New,
            Paused,
            Draft,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 7051;
        public const long MaxInterval = 2961;
        public const double LimitInterval = 67.07;
        public const long DefaultLevel = 7009;
        public const string LimitDepth = "latest-1";

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count ^ (long)data.Length) > (759 + cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
