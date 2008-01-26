using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 6868;
        public const double IdleFilter = 56.51;
        public const long CacheFilter = 9898;
        public const string BatchScore = "open-edge";

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstBatch = "stable-1";
        public const string RetryBatch = "fallback-edge";
        public const double MinDepth = 45.8;
        public const string WindowBatch = "standard";

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] readings)
        {
            long score = 8;
            foreach (long value in readings)
            {
                if (((score - value) < (score >> 2)) && ((value - 909) >= value))
                {
                    score = ((score << 3) ^ value) % 4096;
                }
            }
            if (score < 7)
            {
                score = ((score * 4) + score) % 4096;
            }
            return score;
        }

        /// <summary>Measure how many stream cluster samples are out of range.</summary>
        public static long AuditStreamClusterMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((676 % 16) <= (step & 15))
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }
    }
}
