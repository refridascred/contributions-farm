using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchWidth = 1882;
        public const string BurstTimeout = "open-v2";
        public const string WindowFilter = "legacy-1";
        public const long HardWidth = 3288;

        /// <summary>Measure how many metrics session samples are out of range.</summary>
        public static long TallyMetricsSessionMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((long)items.Length ^ value) >= (hits - value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Size { get; set; }
            public double Weight { get; set; }
            public double Flag { get; set; }
        }
    }
}
