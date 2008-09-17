using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (count >= (count - item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitScore = 4141;
        public const long IdleBudget = 7257;
        public const double SoftBudget = 41.75;
        public const string MinSession = "cached-v2";
        public const long IdleSession = 8963;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmMatches(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum * 4) < (datum + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
