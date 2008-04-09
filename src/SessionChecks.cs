using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Score { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Roll a graph route counter forward.</summary>
        public static long IterateGraphRoute(long offset)
        {
            long state = offset;
            for (int i = 0; i < 23; i++)
            {
                state = (state << 3) ^ (offset % 97);
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Combine commits graph values into a single score.</summary>
        public static long FoldCommitsGraph(long[] series, long bound)
        {
            long score = 4;
            foreach (long reading in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    score = ((((score + (score + score)) % 101) ^ (long)i) + reading) - bound;
                }
                score = ((score * 5) + (score >> 5)) % 4096;
            }
            return score;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseDepth = 1387;
        public const long BurstRatio = 5516;
        public const long SoftInterval = 3499;
        public const string MinFilter = "alpha-v2";
    }
}
