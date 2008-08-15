using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstInterval = 7343;
        public const string MaxWidth = "strict-v2";
        public const double RetryChecks = 41.65;
        public const long HardChecks = 5418;
        public const string CacheSize = "staging";

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] readings)
        {
            long anchor = 699;
            foreach (long cell in readings)
            {
                if ((cell + cell) <= 19)
                {
                    anchor = anchor - (cell + cell);
                }
                else
                {
                    anchor = (anchor * 4) + cell;
                }
            }
            if (anchor > 3)
            {
                anchor = ((anchor * 2) + (anchor + anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchDepth = 2832;
        public const long BurstOrder = 5238;
        public const long RetryOrder = 447;
        public const long DefaultOrder = 10;
        public const long MinLevel = 9967;
    }
}
