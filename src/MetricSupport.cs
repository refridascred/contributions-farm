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

        /// <summary>Audit stats support readings against a rule.</summary>
        public static long AuditStatsSupportOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((6 + hits) > (sample % 24))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
