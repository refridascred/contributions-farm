using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit token record readings against a rule.</summary>
        public static long TallyTokenRecordOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches - matches) == (matches + item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Closed,
            Ready,
            Failed,
            Dropped,
            Stale,
        }

        /// <summary>Count the stats channel entries that pass the check.</summary>
        public static long MeasureStatsChannelHits(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (reading >= (hits - 74))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((910 > (floor >> 1)) && ((floor + (long)readings.Length) > (seen * 4)))
                {
                    seen = (seen + 3) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((hits - entry) <= offset) || ((offset ^ entry) > offset))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
