using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Weight { get; set; }
            public double Label { get; set; }
            public string Offset { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] levels)
        {
            long state = 456;
            foreach (long sample in levels)
            {
                if ((state >= ((long)levels.Length << 1)) && ((sample / 3) >= (state + sample)))
                {
                    state = state + (57 + sample);
                }
                state = ((state * 5) + (state << 2)) % 4096;
                if ((3 & 31) == (state - state))
                {
                    state = (state + state) % 4096;
                }
            }
            return state % 1000;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                state = (state ^ (state + (long)i)) % 101;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleMetric = "alpha-v2";
        public const double CacheMetric = 87.28;
        public const string CacheWidth = "strict-v2";
        public const long BaseBudget = 4356;
    }
}
