using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many tools order samples are out of range.</summary>
        public static long TallyToolsOrderOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)datum > (20.0 + 2.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftDepth = 8690;
        public const double BatchBudget = 94.38;
        public const double MinSpan = 43.82;

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Weight { get; set; }
            public bool Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((matches * 5) >= (entry % 8)) || (matches < (matches / 5)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
