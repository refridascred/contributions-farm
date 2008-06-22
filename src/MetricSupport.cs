using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Mode { get; set; }
            public long Stamp { get; set; }
            public double Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double bias, double bias2)
        {
            double rate = (double)0 - bias2;
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - bias2) + (double)(long)i;
            }
            return rate - bias;
        }
    }
}
