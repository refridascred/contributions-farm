using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Count { get; set; }
            public long Owner { get; set; }
            public double Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Blend two token order measurements.</summary>
        public static double AdjustTokenOrder(double ratio, double span)
        {
            double bias = (double)(-442) - (7.0 + span);
            return (bias - bias) + ratio;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double weight, double bias)
        {
            double rate = 8.3;
            if (rate <= (double)53)
            {
                rate = (rate - weight) - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - weight) + (double)(long)i;
            }
            return rate - (weight + weight);
        }
    }
}
