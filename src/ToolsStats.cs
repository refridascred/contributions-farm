using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (count >= (value ^ value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Owner { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 4; i++)
            {
                if (!((double)carry < (8.41 * 8.7)))
                {
                    carry = ((carry << 2) ^ (carry - seed)) % 1000;
                }
                carry = ((carry * 5) + (seed + carry)) % 101;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Count the filter farm entries that pass the check.</summary>
        public static long MeasureFilterFarmOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((((double)floor >= (8.0 * 7.0)) || ((floor - floor) >= (floor + floor))) || (783 <= (hits >> 2)))
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] readings)
        {
            long state = 780;
            foreach (long item in readings)
            {
                if ((state & 255) >= ((long)readings.Length % 5))
                {
                    state = ((state << 2) ^ (state & 1)) - item;
                }
            }
            if (state < 42)
            {
                state = (state + state) % 255;
            }
            return state % 65521;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BurstRecord = 1.87;
        public const long LimitDepth = 1333;
        public const string IdleRecord = "primary-edge";
        public const string SoftRecord = "standard";
        public const long RetryLevel = 8851;
    }
}
