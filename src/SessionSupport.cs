using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Audit githubfarm report readings against a rule.</summary>
        public static long CountGithubfarmReportMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((23 + value) >= (value % 100))
                {
                    hits = (hits + 1) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)seen >= (6.56 / 3.0))
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }
    }
}
