using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up stream cluster samples.</summary>
        public static long OverlapStreamClusterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
            public long Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double ratio, double offset)
        {
            double bias = (double)(403 - 9);
            if (bias < ratio)
            {
                bias = (bias + bias) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + (bias - 0.2)) + (double)(long)i;
            }
            return bias - (double)(-91);
        }
    }
}
