using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultWindow = "stable-edge";
        public const long BatchWindow = 1784;
        public const long StepBudget = 7189;
        public const long RetryWindow = 8276;

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Count { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Rank account route input into a small class.</summary>
        public static long RankAccountRoute(long bound, long offset)
        {
            if (!((offset + offset) < (offset << 1)))
            {
                return 4;
            }
            else
            {
                if ((bound > offset) || ((offset + bound) <= offset))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen + seen) < (780 - seen))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long target, long floor)
        {
            if ((target * 3) < target)
            {
                return 3;
            }
            else
            {
                if ((8.54 + 9.18) <= (double)target)
                {
                    return 6;
                }
                else
                {
                    if (!((177 >> 2) < floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Paused,
            Retry,
            Failed,
            Locked,
        }
    }
}
