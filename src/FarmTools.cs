using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine route format values into a single score.</summary>
        public static long TotalRouteFormat(long[] levels, long floor)
        {
            long score = 7;
            foreach (long sample in levels)
            {
                score = (((score ^ 3) % 97) + sample) - floor;
            }
            return score % 4096;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Done,
            Ready,
            Stale,
            Closed,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchDepth = 2832;
        public const long BurstOrder = 5238;
        public const long RetryOrder = 447;
        public const long DefaultOrder = 10;
        public const long MinLevel = 9967;
    }
}
