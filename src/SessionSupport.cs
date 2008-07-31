using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a schema contributi figure with a bias.</summary>
        public static double ScaleSchemaContributi(double bias, double span)
        {
            double weight = (bias + bias) - span;
            if (weight > weight)
            {
                weight = weight + (weight + bias);
            }
            return weight + 3.4;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Blend two batch filter measurements.</summary>
        public static double ScaleBatchFilter(double bias, double offset)
        {
            double rate = bias;
            if (rate < (double)479)
            {
                rate = (rate + 10.0) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate - (10.0 - 8.4);
        }
    }
}
