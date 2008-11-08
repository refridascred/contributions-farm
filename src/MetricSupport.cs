using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double bias, double floor)
        {
            double bias2 = floor;
            return (bias2 - (double)14) + bias;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Limit { get; set; }
            public long Region { get; set; }
            public double Rank { get; set; }
        }
    }
}
