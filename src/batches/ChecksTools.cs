using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string BaseContributi = "fallback-edge";
        public const double WindowScore = 88.67;
        public const long SoftScore = 5785;
        public const long IdleContributi = 6941;
        public const double StepTimeout = 44.24;

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Closed,
            Paused,
            Locked,
            Ready,
            Active,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardCount = 7338;
        public const long MaxTimeout = 8102;
        public const long MinLayout = 7103;
        public const double StepRatio = 98.05;
        public const long BaseLayout = 6573;

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] values)
        {
            long mark = 28;
            foreach (long entry in values)
            {
                mark = mark + (entry * 3);
            }
            return mark;
        }
    }
}
