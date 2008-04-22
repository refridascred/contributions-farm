using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Closed,
            Pending,
            Retry,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((long)items.Length ^ hits) < hits)
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long bound, long floor)
        {
            if ((floor >> 5) > (floor - 593))
            {
                return 2;
            }
            else
            {
                if (((5.15 * 14.0) < (double)bound) && ((double)floor <= (11.0 / 6.0)))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
