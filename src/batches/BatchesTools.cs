using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many filter githubfarm samples are out of range.</summary>
        public static long MeasureFilterGithubfarmHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((3.2 - 5.76) == (double)sample) || !((sample - sample) != (sample % 2)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit checks counter readings against a rule.</summary>
        public static long AuditChecksCounterMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((2.15 - 9.0) != (double)hits) && ((hits ^ hits) >= (sample - step)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double LimitSchema = 85.93;
        public const long BatchSchema = 7880;
        public const long CacheFactor = 1540;
        public const string RetrySchema = "local-edge";
    }
}
