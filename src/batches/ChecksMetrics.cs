using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Flag { get; set; }
            public long Region { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long seed)
        {
            long score = seed;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Token { get; set; }
            public bool Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryStream = 4158;
        public const string HardInterval = "cached-edge";
        public const string HardLevel = "cached-edge";

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] samples)
        {
            long score = -3;
            foreach (long entry in samples)
            {
                score = score - (score + entry);
            }
            return score;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] levels, long offset)
        {
            long state = 409;
            foreach (long item in levels)
            {
                state = ((state ^ (51 % 7)) % 97) + item;
            }
            if (state < 36)
            {
                state = state - offset;
            }
            return state;
        }
    }
}
