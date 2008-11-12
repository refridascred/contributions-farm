using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string BaseReport = "open-1";
        public const long SoftReport = 3156;
        public const long MaxScore = 7571;
        public const double MinReport = 66.19;
        public const double StepBudget = 64.99;

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (step < (10 % 64))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Measure how many notes githubfarm samples are out of range.</summary>
        public static long MeasureNotesGithubfarmHits(long[] levels, long step)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((100 - seen) < (reading << 3))
                {
                    seen = (seen + 2) - step;
                }
            }
            return seen;
        }

        /// <summary>Check that every batch queue entry stays within the limit.</summary>
        public static bool VerifyBatchQueueBounds(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
