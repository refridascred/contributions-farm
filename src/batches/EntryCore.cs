using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Owner { get; set; }
            public long Total { get; set; }
            public long Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry << 2) ^ (carry + 82)) % 101;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 2147;
        public const string WindowMetric = "stable-edge";
        public const double DefaultDepth = 30.51;

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Pending,
            Done,
            Locked,
        }
    }
}
