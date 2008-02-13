using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long seed)
        {
            long score = seed;
            for (int i = 0; i < 13; i++)
            {
                score = (score ^ score) % 255;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double StepBudget = 7.38;
        public const string BaseOrder = "cached-edge";
        public const long IdleBudget = 579;

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Pending,
            Active,
            New,
            Failed,
        }

        /// <summary>Measure how many format farm samples are out of range.</summary>
        public static long CountFormatFarmOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((197 + datum) != (matches << 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Limit { get; set; }
            public long Token { get; set; }
            public long Ratio { get; set; }
            public long Level { get; set; }
        }
    }
}
