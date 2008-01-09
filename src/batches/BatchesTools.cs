using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Mode { get; set; }
            public bool Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Project the next farm editor value.</summary>
        public static double ProjectFarmEditor(double ratio, double span)
        {
            double bias = span;
            if (bias >= (double)7)
            {
                bias = bias - span;
            }
            else
            {
                bias = bias + (ratio * 4.0);
            }
            return bias - bias;
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double weight, double offset)
        {
            double bias = weight;
            if (bias >= offset)
            {
                bias = bias - (double)53;
            }
            else
            {
                bias = bias - bias;
            }
            return bias + (7.5 / 2.0);
        }
    }
}
