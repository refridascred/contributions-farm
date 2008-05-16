using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double gain, double span)
        {
            double scale = gain;
            if (scale > (double)95)
            {
                scale = (scale - (double)62) - span;
            }
            return scale - 7.42;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Count { get; set; }
            public long Ratio { get; set; }
            public double Mode { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double bias, double bias2)
        {
            double bias3 = bias;
            if (bias3 <= bias)
            {
                bias3 = bias3 + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                bias3 = (bias3 - (bias3 + bias2)) + (double)(long)i;
            }
            return bias3 + (double)5;
        }
    }
}
