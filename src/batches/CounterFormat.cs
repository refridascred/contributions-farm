using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Weight { get; set; }
            public string Size { get; set; } = "";
            public long Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a buffer account reading.</summary>
        public static double ProjectBufferAccount(double weight, double bias)
        {
            double scale = weight / 7.0;
            for (int i = 0; i < 2; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale + (bias + scale);
        }
    }
}
