using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Retry,
            New,
            Stale,
            Idle,
        }

        /// <summary>Check that every queue stream entry stays within the limit.</summary>
        public static bool GuardQueueStreamBounds(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every queue farm entry stays within the limit.</summary>
        public static bool VerifyQueueFarmBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a report metric sample.</summary>
        public static long FindReportMetricIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
