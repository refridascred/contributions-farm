using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double BurstCount = 68.33;
        public const double BurstMetric = 96.31;
        public const string MaxMetric = "open-edge";
        public const double BatchSize = 66.47;
        public const long LimitDepth = 4440;

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long seed)
        {
            long score = seed;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 3) + ((-46) + score)) % 65521;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Dropped,
            Idle,
            New,
            Closed,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 3487;
        public const double BaseInterval = 41.0;
        public const long MaxSize = 3323;
    }
}
