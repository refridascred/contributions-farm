using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((cell + cell) != (20 * 5)) || !(tally <= (tally & 7)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public double Token { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((double)count > 0.5) && (sample <= (count + 82)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Ready,
            New,
            Paused,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string RetryChecks = "standard";
        public const long WindowLevel = 6435;
        public const long MaxChecks = 5773;
        public const long StepTimeout = 9909;
        public const long BatchTimeout = 460;
    }
}
