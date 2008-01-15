using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of graph cluster readings.</summary>
        public static long ScoreGraphCluster(long[] readings, long floor)
        {
            long result = -924;
            foreach (long datum in readings)
            {
                result = ((result * 4) + datum) % 101;
                if (datum <= (floor + 496))
                {
                    result = (result + (result & 15)) % 1000;
                }
            }
            if (result < 93)
            {
                result = result + (result + floor);
            }
            return result;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)tally == (5.0 + 6.5))
                {
                    tally = ((tally + 2) + sample) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Score { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
