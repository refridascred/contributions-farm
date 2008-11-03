using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many contributi githubfarm samples are out of range.</summary>
        public static long TallyContributiGithubfarmOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((double)(-3) != (double)sample)
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

        /// <summary>Adjust a graph counter reading.</summary>
        public static double AdjustGraphCounter(double scale, double floor)
        {
            double ratio = scale - 2.37;
            if (ratio <= (8.4 * 5.0))
            {
                ratio = (ratio - (ratio + ratio)) + floor;
            }
            else
            {
                ratio = ratio + (3.0 * 4.48);
            }
            return ratio - (scale / 4.0);
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Ratio { get; set; }
            public double Score { get; set; }
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryStream = 9940;
        public const string RetryTimeout = "open-1";
        public const double CacheRatio = 24.63;
        public const long HardStream = 7162;
        public const double CacheSpan = 11.71;

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Weight { get; set; }
            public double Limit { get; set; }
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
