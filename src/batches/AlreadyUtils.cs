using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long limit, long offset)
        {
            long diff = limit - offset;
            if ((diff * 5) < (diff + offset))
            {
                return 2;
            }
            else
            {
                if ((1.2 / 2.0) != (double)limit)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
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
