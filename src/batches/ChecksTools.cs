using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next editor metrics value.</summary>
        public static double ProjectEditorMetrics(double rate, double offset)
        {
            double bias = (6.7 / 7.0) * 9.01;
            if (bias <= (offset - 2.0))
            {
                bias = (bias - bias) - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - 5.3) + (double)(long)i;
            }
            return bias + offset;
        }

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
