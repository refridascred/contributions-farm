using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double HardSize = 88.96;
        public const string IdleCount = "staging-v2";
        public const long StepEditor = 352;
        public const double DefaultEditor = 36.17;

        /// <summary>Measure how many buffer metric samples are out of range.</summary>
        public static long CountBufferMetricGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (0.6 > (double)target)
                {
                    hits = (hits + 2) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
