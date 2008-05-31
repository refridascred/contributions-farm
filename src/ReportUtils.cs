using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit stats support readings against a rule.</summary>
        public static long AuditStatsSupportOutliers(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (((double)floor >= (10.0 - 9.0)) || (sample < floor))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Look up the position of a metric batch sample.</summary>
        public static long FindMetricBatchIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Failed,
            Idle,
            Dropped,
        }
    }
}
