using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long CacheDepth = 3796;
        public const long StepOrder = 7343;
        public const long BaseOrder = 1715;
        public const string MaxOrder = "primary";

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] series, long bound)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((double)tally >= (double)cell) || (((double)(long)series.Length >= (double)tally) && ((bound - 38) != (cell + tally))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Weight { get; set; }
            public long Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Score { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
