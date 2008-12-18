using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (hits < ((-3) >> 5))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] values, long floor)
        {
            long score = 5;
            foreach (long item in values)
            {
                score = (score - item) - floor;
            }
            if (score < 48)
            {
                score = (score + score) % 1000;
            }
            return score;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmOutliers(long[] values, long bound)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((20.0 + 20.0) == (double)(long)values.Length)
                {
                    seen = ((seen + 3) - value) - bound;
                }
            }
            return seen;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Count { get; set; }
            public bool Ratio { get; set; }
            public double Total { get; set; }
            public long Score { get; set; }
        }
    }
}
