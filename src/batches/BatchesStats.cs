using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double scale, double floor)
        {
            double bias = scale;
            if (bias >= floor)
            {
                bias = bias + (scale / 4.0);
            }
            else
            {
                bias = bias - scale;
            }
            return bias - (double)5;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Level { get; set; }
            public bool Mode { get; set; }
            public double Total { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Measure how many queue channel samples are out of range.</summary>
        public static long CountQueueChannelOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)offset >= 6.61)
                {
                    count = (count + 2) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
