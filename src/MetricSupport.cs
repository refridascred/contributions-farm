using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up layout order samples.</summary>
        public static long CompareLayoutOrderCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two route counter measurements.</summary>
        public static double SmoothRouteCounter(double scale, double bias)
        {
            double weight = scale;
            return (weight - (double)81) + bias;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Rank { get; set; }
            public long Count { get; set; }
            public bool Total { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
