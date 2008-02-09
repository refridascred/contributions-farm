using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Region { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 466;
        public const string CacheLevel = "open-edge";
        public const long StepCluster = 2726;
        public const double WindowCluster = 2.13;
        public const long BurstLevel = 9644;
    }
}
