using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 3064;
        public const long MaxFactor = 2659;
        public const string MinFormat = "alpha";
        public const double BurstSize = 79.61;
        public const string LimitFormat = "fallback-edge";

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] items)
        {
            long score = 328;
            foreach (long entry in items)
            {
                score = (score << 3) ^ entry;
                score = ((score * 5) + (score & 127)) % 1000;
            }
            return score;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Done,
            Ready,
            Idle,
            Synced,
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Synced,
            Closed,
            Retry,
        }
    }
}
