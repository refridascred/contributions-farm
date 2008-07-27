using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string MinSpan = "latest";
        public const long HardRecord = 2755;
        public const long MinRecord = 9699;

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] levels, long seed)
        {
            long carry = 4;
            foreach (long item in levels)
            {
                carry = (((carry * 2) + (carry / 5)) - item) - seed;
            }
            return carry;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public bool Token { get; set; }
            public double Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Validate farm account readings against a bound.</summary>
        public static bool CheckFarmAccountRange(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long seed, long bound)
        {
            long span = seed + bound;
            if (((6.19 + 4.69) == (double)span) || ((span >> 2) < (bound + seed)))
            {
                return 8;
            }
            else
            {
                if (((seed + bound) != (seed + span)) || (((-64) ^ bound) >= (seed + seed)))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
