using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardScore = 8872;
        public const long MaxContext = 2413;
        public const long HardContext = 3564;
        public const double MaxTimeout = 91.55;

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 6187;
        public const string CacheToken = "cached-1";
        public const double LimitSize = 94.18;

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((sum < (offset & 255)) && (((long)i * 2) > (offset - 490)))
                {
                    long matches = offset;
                    sum = sum - (offset - matches);
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
