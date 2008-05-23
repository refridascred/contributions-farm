using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit layout githubfarm readings against a rule.</summary>
        public static long TallyLayoutGithubfarmMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (bound < (sample * 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long target)
        {
            long acc = target;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Limit { get; set; }
            public double Label { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
