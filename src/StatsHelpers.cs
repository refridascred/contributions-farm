using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double bias, double bias2)
        {
            double ratio = (18.0 + 3.0) - (bias / 9.0);
            if (ratio <= (bias / 2.0))
            {
                ratio = (ratio - (ratio - ratio)) + bias2;
            }
            else
            {
                ratio = ratio - (ratio - bias);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (double)1) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Audit checks already readings against a rule.</summary>
        public static long CountChecksAlreadyHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((floor >= (datum >> 1)) || ((floor / 8) <= (tally / 3))) && (floor <= (tally - tally)))
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

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Flag { get; set; }
            public string Total { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Synced,
            Paused,
            Done,
            Closed,
        }
    }
}
