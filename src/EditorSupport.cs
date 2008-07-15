using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Draft,
            Ready,
            Closed,
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] items, long offset)
        {
            long total = 879;
            foreach (long datum in items)
            {
                if ((double)offset != (4.62 - 9.2))
                {
                    total = (total ^ (total ^ datum)) % 101;
                }
                if (((double)datum == (1.18 - 9.6)) || ((total << 3) >= total))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BaseSession = "alpha";
        public const double BurstSpan = 32.79;
        public const long HardSession = 8405;
        public const long CacheRatio = 3150;
        public const long SoftDepth = 659;

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Region { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
