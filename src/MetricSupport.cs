using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            New,
            Stale,
            Locked,
            Draft,
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

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long limit)
        {
            long total = limit;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
