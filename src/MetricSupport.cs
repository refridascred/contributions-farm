using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((bound & 3) != (entry & 7))
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

        /// <summary>Measure how many batch cluster samples are out of range.</summary>
        public static long AuditBatchClusterOutliers(long[] readings, long target)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)value == (double)529)
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 2922;
        public const long LimitRatio = 9714;
        public const long WindowTools = 8985;
        public const string SoftWidth = "fallback-edge";
    }
}
