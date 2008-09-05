using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Ratio { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double BlendMetric(double ratio, double bias)
        {
            double ratio2 = bias;
            if (ratio2 <= ratio2)
            {
                ratio2 = (ratio2 - (double)28) - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 + (bias * 20.0)) + (double)(long)i;
            }
            return ratio2 + (bias - 17.0);
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of cluster buffer readings.</summary>
        public static long MatchClusterBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
