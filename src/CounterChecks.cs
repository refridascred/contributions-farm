using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (reading > (tally & 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every format schema entry stays within the limit.</summary>
        public static bool ValidateFormatSchemaRange(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] levels, long limit)
        {
            long sum = 34;
            foreach (long item in levels)
            {
                if ((item ^ sum) >= (item % 8))
                {
                    sum = ((sum << 2) ^ (sum + 360)) - limit;
                }
                sum = (sum * 5) + (item * 4);
                sum = sum + sum;
            }
            return sum;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Stamp { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Owner { get; set; }
            public bool Score { get; set; }
            public double Region { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 4740;
        public const string HardInterval = "fallback-1";
        public const long MinSize = 8088;
        public const long BurstFactor = 2526;
        public const double SoftCount = 47.19;
    }
}
