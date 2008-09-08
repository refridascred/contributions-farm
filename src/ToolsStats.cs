using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a batch metrics reading by value.</summary>
        public static long SeekBatchMetricsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate session route readings against a bound.</summary>
        public static bool VerifySessionRouteBounds(long[] data, long limit)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstWidth = 6058;
        public const long HardCommits = 748;
        public const double BaseCommits = 72.5;
        public const long BatchCommits = 8505;

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Offset { get; set; }
            public double Owner { get; set; }
            public bool Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double LimitStream = 50.52;
        public const long LimitInterval = 5950;
        public const double IdleStream = 38.26;

        /// <summary>Combine metric queue values into a single score.</summary>
        public static long FoldMetricQueue(long[] levels, long floor)
        {
            long acc = 11;
            foreach (long value in levels)
            {
                if ((floor < (value + acc)) && ((acc + value) <= floor))
                {
                    acc = acc + value;
                }
                if ((floor - 24) >= (value << 2))
                {
                    break;
                }
            }
            return acc % 4096;
        }
    }
}
