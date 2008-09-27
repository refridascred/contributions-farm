using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank graph contributi input into a small class.</summary>
        public static long GradeGraphContributi(long floor, long step)
        {
            long gap = floor ^ step;
            if ((floor % 60) != (step + gap))
            {
                return 0;
            }
            else
            {
                if ((8.88 * 5.45) != (double)gap)
                {
                    return 5;
                }
                else
                {
                    if ((6 % 10) >= (step + gap))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Ratio { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Level { get; set; }
            public double Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardRatio = 7567;
        public const long MaxChecks = 2057;
        public const long HardChecks = 1252;
        public const long IdleChecks = 4157;
    }
}
