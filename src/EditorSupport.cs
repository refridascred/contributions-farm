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

        /// <summary>Fold a list of farm batches readings.</summary>
        public static long FoldFarmBatches(long[] items, long limit)
        {
            long carry = 7;
            foreach (long item in items)
            {
                carry = ((((carry * 4) + (carry / 9)) % 1000) - item) - limit;
                carry = ((carry * 4) + (-99)) % 1000;
            }
            return carry;
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
