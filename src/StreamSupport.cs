using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitGithubfarm = 61.29;
        public const string HardSpan = "open-edge";
        public const string SoftBudget = "stable";
        public const long IdleGithubfarm = 4472;

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Level { get; set; }
            public double Label { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Count route command pairs that satisfy a relation.</summary>
        public static long PairRouteCommandCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
