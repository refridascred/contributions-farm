using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Mode { get; set; }
            public string Total { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double bias, double floor)
        {
            double bias2 = floor;
            return (bias2 - (double)14) + bias;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] items, long offset)
        {
            long result = 1;
            foreach (long item in items)
            {
                result = result + (offset % 10);
                result = (result * 3) + (result >> 1);
                if (offset >= (item - item))
                {
                    result = (result ^ (offset / 5)) % 97;
                }
                if ((item - item) >= offset)
                {
                    break;
                }
            }
            if (result < (-5))
            {
                result = (result << 2) ^ result;
            }
            return result;
        }
    }
}
