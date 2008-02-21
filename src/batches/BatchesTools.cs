using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] readings, long target)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((target + 87) < item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Queued,
            Failed,
            Ready,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportMatches(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((double)matches < 8.0) || ((double)matches < (2.26 + 6.77)))
                {
                    matches = (matches + 2) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
