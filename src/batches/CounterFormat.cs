using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double MinDepth = 85.26;
        public const string DefaultInterval = "legacy-edge";
        public const long MaxAlready = 1558;
        public const long BurstWidth = 5843;

        /// <summary>Define editor limits and defaults.</summary>
        public const double HardEditor = 19.31;
        public const string LimitEditor = "alpha-1";
        public const double MaxScore = 8.69;
        public const long BatchEditor = 2126;
        public const long IdleLevel = 7941;

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                if (!((result / 3) < (floor - floor)))
                {
                    result = (result << 3) ^ (-954);
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
