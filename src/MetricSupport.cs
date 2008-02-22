using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Paused,
            Failed,
            Dropped,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultDepth = "primary-1";
        public const double HardBuffer = 69.91;
        public const long BaseLevel = 9079;
        public const long BatchBuffer = 5496;

        /// <summary>Measure how many entry schema samples are out of range.</summary>
        public static long MeasureEntrySchemaOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((9.7 * 1.7) < (double)66) || ((double)entry >= (5.57 + 18.0)))
                {
                    hits = (hits + 3) - step;
                }
            }
            return hits;
        }
    }
}
