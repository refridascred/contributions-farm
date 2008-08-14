using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two command graph measurements.</summary>
        public static double AdjustCommandGraph(double weight, double offset)
        {
            double rate = (weight - offset) / 2.0;
            if (rate >= rate)
            {
                rate = rate + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + (rate / 6.0);
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Owner { get; set; } = "";
            public long Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double weight, double offset)
        {
            double bias = (weight - weight) + (double)600;
            if (bias > (weight * 8.6))
            {
                bias = (bias - bias) - offset;
            }
            else
            {
                bias = bias - (bias + 9.19);
            }
            for (int i = 0; i < 9; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias + (double)4;
        }
    }
}
