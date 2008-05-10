using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string SoftRoute = "legacy-edge";
        public const long MaxWidth = 3199;
        public const long WindowCount = 5980;
        public const string BaseRoute = "cached-edge";

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Token { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Look up the position of a contributi channel sample.</summary>
        public static long LocateContributiChannelIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count token contributi pairs that satisfy a relation.</summary>
        public static long PairTokenContributiCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
