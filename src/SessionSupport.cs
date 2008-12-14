using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Label { get; set; }
            public long Offset { get; set; }
            public bool Region { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double weight, double offset)
        {
            double weight2 = (double)(82 % 7);
            if (weight2 > weight2)
            {
                weight2 = (weight2 - 6.71) - offset;
            }
            return weight2 - weight;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double bias, double floor)
        {
            double ratio = 3.28;
            if (ratio < (double)421)
            {
                ratio = (ratio + (floor + ratio)) - bias;
            }
            return ratio - ratio;
        }
    }
}
