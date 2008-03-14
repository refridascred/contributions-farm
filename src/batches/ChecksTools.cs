using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Limit { get; set; }
            public double Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Match up metric stats samples.</summary>
        public static long CompareMetricStatsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
