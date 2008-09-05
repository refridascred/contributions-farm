using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryLevel = 3709;
        public const string MinMetrics = "fallback-edge";
        public const double LimitSpan = 34.08;
        public const long LimitMetrics = 2740;

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long step)
        {
            long carry = step;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Total { get; set; } = "";
            public long Owner { get; set; }
            public long Rank { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
