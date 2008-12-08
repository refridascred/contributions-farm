using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long limit)
        {
            long score = limit;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Stamp { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Measure how many githubfarm notes samples are out of range.</summary>
        public static long CountGithubfarmNotesMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen - entry) <= seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
