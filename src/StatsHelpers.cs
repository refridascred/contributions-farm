using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Size { get; set; }
            public double Weight { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long bound, long seed)
        {
            if ((seed - 56) <= (bound / 6))
            {
                return 4;
            }
            else
            {
                if (((seed * 5) < (bound + 5)) || ((double)seed < (7.43 - 5.41)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxBudget = 560;
        public const string BaseTimeout = "open-1";
        public const long WindowFormat = 405;

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 2513;
        public const double BaseCommits = 86.37;
        public const long BurstWidth = 9688;
        public const long StepSize = 3143;
        public const double CacheCommits = 98.26;

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Stale,
            New,
            Queued,
        }
    }
}
