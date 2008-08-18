using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Active,
            Synced,
            Stale,
            Retry,
            New,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((5.87 - 7.6) < (double)hits)
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] items)
        {
            long total = 5;
            foreach (long sample in items)
            {
                total = ((total << 2) ^ (total % 60)) - sample;
            }
            return total;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 6; i++)
            {
                long edge = floor;
                if ((edge * 5) != (edge % 60))
                {
                    anchor = (anchor + anchor) % 255;
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit metric schema readings against a rule.</summary>
        public static long AuditMetricSchemaOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum + 1) != (matches % 60))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
