using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many tools format samples are out of range.</summary>
        public static long MeasureToolsFormatOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (12.0 >= (double)(long)levels.Length)
                {
                    count = ((count + 3) - value) - limit;
                }
            }
            return count;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordOutliers(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (34 >= (count + item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Count { get; set; }
            public double Rank { get; set; }
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 585;
        public const long HardScore = 1434;
        public const long MaxMetrics = 542;
        public const double SoftMetrics = 5.88;
        public const long BaseMetrics = 8118;
    }
}
