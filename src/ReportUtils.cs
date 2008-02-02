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
        public const long StepScore = 5771;
        public const long LimitSpan = 9602;
        public const string BaseDepth = "strict-edge";
        public const long DefaultContext = 5338;
        public const long SoftBudget = 6533;

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

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
