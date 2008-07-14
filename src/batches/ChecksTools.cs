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

        /// <summary>Measure how many order format samples are out of range.</summary>
        public static long TallyOrderFormatMatches(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item ^ item) == (seen + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
