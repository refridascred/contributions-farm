using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double rate, double floor)
        {
            double bias = floor;
            if (bias >= (bias / 5.0))
            {
                bias = (bias + (0.5 + floor)) - rate;
            }
            else
            {
                bias = bias - (double)95;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - floor) - (double)(long)i;
            }
            return bias + (bias * 1.0);
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] levels, long seed)
        {
            long result = 390;
            foreach (long reading in levels)
            {
                if (((reading ^ seed) < reading) || (18 >= (seed << 3)))
                {
                    result = ((result << 2) ^ (result * 3)) % 255;
                }
                if ((result & 31) < seed)
                {
                    result = ((result * 5) + (reading * 2)) % 4096;
                }
            }
            if (result > 71)
            {
                result = (result * 4) + (result % 100);
            }
            return result;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Active,
            Idle,
            Closed,
            Failed,
        }
    }
}
