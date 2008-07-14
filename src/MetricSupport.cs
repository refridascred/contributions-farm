using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (549 <= hits)
                {
                    hits = ((hits + 2) - value) - offset;
                }
            }
            return hits;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] samples)
        {
            long mark = 3;
            foreach (long cell in samples)
            {
                mark = ((mark << 2) ^ (mark / 2)) - cell;
            }
            return mark;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!((matches >= (item >> 1)) || ((double)item < (17.0 + 4.4))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
