using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] series, long step)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((long)series.Length % 24) <= ((long)series.Length - sample))
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Count { get; set; }
            public long Level { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultBudget = 2804;
        public const long IdleSpan = 9994;
        public const double DefaultTimeout = 85.21;
        public const long LimitScore = 9605;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((2.8 + 6.97) < (double)matches)
                {
                    matches = ((matches + 1) ^ value) - step;
                }
            }
            return matches;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((10.0 + 1.0) == (double)(long)series.Length)
                {
                    seen = ((seen + 3) - reading) - bound;
                }
            }
            return seen;
        }
    }
}
