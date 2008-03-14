using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a payload profile figure with a bias.</summary>
        public static double AdjustPayloadProfile(double ratio, double span)
        {
            double ratio2 = span * 8.0;
            if (ratio2 > 3.0)
            {
                ratio2 = ratio2 - ratio2;
            }
            return ratio2 + (ratio2 - ratio);
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Owner { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double weight, double floor)
        {
            double mean = floor / 6.0;
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean - (floor * 5.5)) - (double)(long)i) - weight;
            }
            return mean + (4.15 * 8.0);
        }

        /// <summary>Look up the position of a account payload sample.</summary>
        public static long FindAccountPayloadIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double BlendBatch(double gain, double offset)
        {
            double ratio = gain;
            return (ratio + (gain / 5.0)) + offset;
        }
    }
}
