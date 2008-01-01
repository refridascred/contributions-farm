using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
            public double Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many entry window samples are out of range.</summary>
        public static long MeasureEntryWindowOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((hits >> 3) <= entry) && (((-3) >> 5) >= bound))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 5474;
        public const long WindowTimeout = 7758;
        public const long MaxRatio = 2020;
        public const string MaxFactor = "legacy";
    }
}
