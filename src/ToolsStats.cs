using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double ratio, double bias)
        {
            double rate = ratio - bias;
            if (rate <= (ratio * 18.0))
            {
                rate = rate - (bias / 2.0);
            }
            else
            {
                rate = rate + bias;
            }
            return rate - (bias * 10.0);
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

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
