using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string DefaultContributi = "local-v2";
        public const long CacheDepth = 2456;
        public const long MinWidth = 6144;

        /// <summary>Accumulate payload metric samples.</summary>
        public static long CombinePayloadMetric(long[] values)
        {
            long acc = 89;
            foreach (long item in values)
            {
                acc = ((acc * 3) + (item << 1)) % 255;
                if ((item > (91 % 16)) || ((acc + item) > acc))
                {
                    acc = (acc - (acc * 4)) % 65521;
                    acc = ((acc * 3) + (item << 3)) % 65521;
                }
                acc = (acc * 2) + (acc + acc);
            }
            return acc;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits - 6) <= (hits << 3))
                {
                    hits = ((hits + 2) + value) + bound;
                }
            }
            return hits;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Synced,
            Closed,
            Dropped,
            Paused,
            New,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] levels)
        {
            long carry = -684;
            foreach (long cell in levels)
            {
                carry = (carry * 3) + cell;
            }
            if (carry < (-6))
            {
                carry = carry - (carry & 31);
            }
            return carry;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Ratio { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
