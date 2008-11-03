using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardGithubfarm = "alpha-edge";
        public const long BurstSize = 622;
        public const long BatchGithubfarm = 5558;
        public const long RetryGithubfarm = 1353;
        public const long LimitTimeout = 6451;

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
