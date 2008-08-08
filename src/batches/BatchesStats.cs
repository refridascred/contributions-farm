using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double weight, double span)
        {
            double load = (double)528 + span;
            if (load >= (span - 6.78))
            {
                load = (load - load) - weight;
            }
            return load + (double)9;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double scale, double bias)
        {
            double ratio = scale;
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio - (3.0 - scale)) + (double)(long)i) - bias;
            }
            return ratio + (double)6;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double rate, double floor)
        {
            double bias = (double)(758 + 694);
            if (bias >= bias)
            {
                bias = bias - (double)5;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + floor) + (double)(long)i;
            }
            return bias + (rate / 8.0);
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Level { get; set; }
            public long Ratio { get; set; }
        }
    }
}
