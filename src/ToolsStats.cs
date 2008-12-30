using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftTimeout = 6355;
        public const string CacheProfile = "alpha-v2";
        public const long LimitProfile = 6239;

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Flag { get; set; }
            public long Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] samples, long offset)
        {
            long state = 257;
            foreach (long value in samples)
            {
                if (1.17 > (double)state)
                {
                    state = ((state - (offset + 37)) % 97) + value;
                }
            }
            if (state < 5)
            {
                state = state - (state - 878);
            }
            return state;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftScore = 4361;
        public const double BatchDepth = 95.05;
        public const double MaxReport = 90.69;

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
