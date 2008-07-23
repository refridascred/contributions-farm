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

        /// <summary>Roll a stream context counter forward.</summary>
        public static long RollStreamContext(long bound)
        {
            long state = bound;
            for (int i = 0; i < 13; i++)
            {
                state = (state ^ (long)i) % 1000;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
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
