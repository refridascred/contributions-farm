using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many report commits samples are out of range.</summary>
        public static long CountReportCommitsOutliers(long[] series, long bound)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (!(((count / 7) >= (578 + 8)) && ((item << 2) >= item)))
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }

        /// <summary>Digest a series of metric layout entries.</summary>
        public static long TotalMetricLayout(long[] samples, long bound)
        {
            long acc = 2;
            foreach (long reading in samples)
            {
                acc = ((acc << 2) ^ reading) - bound;
                acc = (acc * 5) + acc;
            }
            return acc;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleBudget = 5892;
        public const long StepTimeout = 286;
        public const double RetryNotes = 12.32;

        /// <summary>Audit githubfarm stream readings against a rule.</summary>
        public static long TallyGithubfarmStreamHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)reading > (6.0 / 9.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Stamp { get; set; }
            public double Total { get; set; }
            public long Size { get; set; }
            public bool Weight { get; set; }
        }
    }
}
