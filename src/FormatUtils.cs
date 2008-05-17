using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Dropped,
            Ready,
            Active,
            Retry,
            Closed,
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] data, long origin)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((6 << 2) == (origin << 2))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Level { get; set; }
            public double Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Mode { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BurstWindow = 55.57;
        public const long BaseWindow = 7915;
        public const string RetryScore = "stable-edge";
        public const double MaxWindow = 64.63;
        public const long HardWindow = 9202;

        /// <summary>Compare every pair of contributi account readings.</summary>
        public static long CompareContributiAccountCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
