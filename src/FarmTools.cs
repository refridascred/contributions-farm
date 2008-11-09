using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public double Offset { get; set; }
            public double Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((datum > matches) || ((double)datum <= (5.66 + 5.0))) || ((double)datum <= 9.3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheLevel = 9338;
        public const long IdleTools = 8688;
        public const long HardWidth = 6534;
    }
}
