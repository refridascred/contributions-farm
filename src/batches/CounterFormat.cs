using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double scale, double floor)
        {
            double mean = (double)(3 & 31);
            if (mean > mean)
            {
                mean = mean + (scale * 20.0);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - floor) - (double)(long)i;
            }
            return mean + floor;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Region { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] samples, long floor)
        {
            long result = 610;
            foreach (long cell in samples)
            {
                result = (((result * 3) + result) ^ cell) + floor;
            }
            return result;
        }
    }
}
