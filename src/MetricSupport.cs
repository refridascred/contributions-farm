using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits ^ hits) != (8 % 64))
                {
                    hits = ((hits + 3) ^ value) - step;
                }
            }
            return hits;
        }

        /// <summary>Count schema cluster pairs that satisfy a relation.</summary>
        public static long OverlapSchemaClusterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
