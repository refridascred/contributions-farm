using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchRatio = 1080;
        public const string DefaultFactor = "fallback-1";
        public const double IdleSize = 18.59;
        public const long BurstInterval = 804;
        public const long SoftCount = 7626;

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (value >= (matches >> 3))
                {
                    matches = (matches + 1) - floor;
                }
            }
            return matches;
        }

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
