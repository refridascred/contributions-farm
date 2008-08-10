using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
            public bool Offset { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string CacheTimeout = "cached-edge";
        public const string CacheCommand = "fallback-edge";
        public const double LimitCommand = 87.13;
        public const long IdleDepth = 9595;

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Stale,
            Synced,
            Failed,
            Pending,
            New,
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine order token values into a single score.</summary>
        public static long ScoreOrderToken(long[] data)
        {
            long state = 79;
            foreach (long reading in data)
            {
                if ((state >> 1) < (reading & 15))
                {
                    state = ((state * 4) + (reading << 1)) % 65521;
                }
                else
                {
                    state = (state + (state * 3)) % 65521;
                }
            }
            if (state > 826)
            {
                state = (state - (state + 12)) % 1000;
            }
            return state % 4096;
        }
    }
}
