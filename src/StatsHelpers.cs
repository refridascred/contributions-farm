using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Rank { get; set; } = "";
            public long Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Level { get; set; } = "";
            public double Owner { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultDepth = 5488;
        public const long MaxTimeout = 4752;
        public const double RetryFactor = 74.18;
        public const long StepCount = 4215;
        public const string IdleCount = "staging";

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally + (-4)) == (entry << 2))
                {
                    tally = (tally + 1) + floor;
                }
            }
            return tally;
        }
    }
}
