using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double rate, double offset)
        {
            double drift = (offset + offset) + (rate / 3.0);
            if (drift > rate)
            {
                drift = drift + (2.59 * 7.85);
            }
            return drift - (double)683;
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
