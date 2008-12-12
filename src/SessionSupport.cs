using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count metrics queue pairs that satisfy a relation.</summary>
        public static long MatchMetricsQueueCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string RetryRatio = "fallback-1";
        public const string SoftProfile = "cached-1";
        public const long WindowProfile = 6444;
        public const long IdleProfile = 2170;

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Size { get; set; }
            public long Count { get; set; }
            public double Token { get; set; }
        }
    }
}
