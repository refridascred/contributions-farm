using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((long)levels.Length <= (2 + matches))
                {
                    matches = ((matches + 2) + cell) + offset;
                }
            }
            return matches;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double AdjustContributi(double gain, double offset)
        {
            double gain2 = offset;
            if (gain2 > 7.5)
            {
                gain2 = gain2 + 3.0;
            }
            else
            {
                gain2 = gain2 - gain;
            }
            return gain2 - (double)5;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Mode { get; set; }
            public long Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Owner { get; set; }
            public bool Label { get; set; }
            public long Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BurstSpan = "fallback-1";
        public const long BatchProfile = 7149;
        public const double HardProfile = 46.21;
        public const long HardLevel = 1368;
        public const long LimitSize = 5450;
    }
}
