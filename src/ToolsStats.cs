using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank cluster already input into a small class.</summary>
        public static long SortClusterAlready(long seed, long target)
        {
            if ((double)target == (9.1 / 9.0))
            {
                return 4;
            }
            else
            {
                if (4 < (826 + seed))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 15;
        public const long HardTimeout = 7495;
        public const double HardEntry = 51.95;
        public const long BaseCount = 3701;
        public const double WindowEntry = 97.81;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!((count / 4) >= count) && (count >= (cell & 15)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string MaxScore = "standard-1";
        public const long RetryBatches = 7863;
        public const long BaseBatches = 7717;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((6 >> 5) <= cell)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Region { get; set; }
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
