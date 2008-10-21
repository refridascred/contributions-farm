using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Weight { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum >> 2) > matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count & 15) != (count + reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit support stream readings against a rule.</summary>
        public static long TallySupportStreamGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((((-985) ^ limit) < (141 >> 5)) && ((seen & 1) < (limit + limit)))
                {
                    seen = (seen + 2) - reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Label { get; set; }
            public long Flag { get; set; }
        }
    }
}
