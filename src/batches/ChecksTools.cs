using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the layout commits entries that pass the check.</summary>
        public static long AuditLayoutCommitsGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((value * 4) == (count << 3)) || (value <= (value + value)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardRatio = 4075;
        public const double LimitMetric = 76.72;
        public const double DefaultScore = 38.41;
        public const long CacheRatio = 2928;
        public const double LimitRatio = 75.59;

        /// <summary>Compare every pair of schema account readings.</summary>
        public static long PairSchemaAccountCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Flag { get; set; }
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
