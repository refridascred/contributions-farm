using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the schema editor entries that pass the check.</summary>
        public static long MeasureSchemaEditorOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count + item) >= 98)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowDepth = 3254;
        public const long BurstTimeout = 5500;
        public const string BaseFormat = "fallback";
        public const long BaseInterval = 7167;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 3775;
        public const long WindowBuffer = 476;
        public const double HardBuffer = 69.92;
        public const string BaseBuffer = "staging-v2";
    }
}
