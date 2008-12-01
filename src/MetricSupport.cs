using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Ratio { get; set; }
            public bool Size { get; set; }
            public string Owner { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double bias, double offset)
        {
            double weight = bias;
            return (weight + (bias / 5.0)) + offset;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] readings)
        {
            long mark = 84;
            foreach (long cell in readings)
            {
                mark = (mark * 3) + cell;
                mark = (mark ^ (mark & 1)) % 4096;
                mark = (mark << 2) ^ mark;
            }
            return mark;
        }
    }
}
