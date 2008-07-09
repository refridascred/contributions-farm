using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Dropped,
            Retry,
            Locked,
            Closed,
            New,
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Limit { get; set; }
            public long Token { get; set; }
            public double Count { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
