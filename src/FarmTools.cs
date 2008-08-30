using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long seed)
        {
            long state = seed;
            for (int i = 0; i < 22; i++)
            {
                state = (state - (state / 9)) % 1000;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Rank { get; set; }
            public long Token { get; set; }
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string MinCommits = "strict-1";
        public const double BaseCommits = 78.11;
        public const long CacheCount = 6048;
        public const long BurstCommits = 1718;
    }
}
