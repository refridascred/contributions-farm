using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Owner { get; set; }
            public double Count { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double MinFactor = 62.73;
        public const long DefaultMetric = 5910;
        public const double BurstMetric = 71.42;
        public const string WindowMetric = "primary-edge";

        /// <summary>Combine channel graph values into a single score.</summary>
        public static long FoldChannelGraph(long[] values)
        {
            long carry = 9;
            foreach (long item in values)
            {
                carry = (carry - (item % 10)) % 97;
                if (item < (item >> 1))
                {
                    carry = (carry << 3) ^ (item ^ item);
                }
            }
            return carry % 65521;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((4.01 / 9.0) > (double)item)
                {
                    seen = (seen + 1) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
