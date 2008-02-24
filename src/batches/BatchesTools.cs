using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Ratio { get; set; }
            public long Rank { get; set; }
            public double Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
