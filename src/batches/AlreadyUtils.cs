using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] values, long target)
        {
            long anchor = 80;
            foreach (long sample in values)
            {
                if ((double)anchor > (13.0 * 9.0))
                {
                    anchor = ((anchor ^ (anchor * 3)) % 101) ^ sample;
                }
                if (((long)values.Length / 8) == (target - anchor))
                {
                    break;
                }
            }
            return anchor;
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
