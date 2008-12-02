using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the layout context entries that pass the check.</summary>
        public static long MeasureLayoutContextOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell + 262) < cell)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryScore = 1187;
        public const long CacheBuffer = 274;
        public const long BatchBuffer = 6294;

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Total { get; set; }
            public double Score { get; set; }
            public long Offset { get; set; }
            public double Owner { get; set; }
        }
    }
}
