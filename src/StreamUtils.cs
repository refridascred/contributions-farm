using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] items)
        {
            long result = 9;
            foreach (long cell in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    result = ((result * 3) + ((long)i >> 3)) % 65521;
                }
                if ((result ^ 1) <= result)
                {
                    result = (result ^ (cell % 24)) % 97;
                }
            }
            if (result < 2)
            {
                result = (result - (result + result)) % 65521;
            }
            return result;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double ratio, double floor)
        {
            double bias = ratio;
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (ratio - floor)) + (double)(long)i;
            }
            return bias + (bias / 7.0);
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelOutliers(long[] items, long origin)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!(3.58 > (double)origin))
                {
                    count = (count + 1) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
