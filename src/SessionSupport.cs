using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double ratio, double span)
        {
            double load = 3.0 * 9.0;
            return (load + span) + ratio;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double gain, double offset)
        {
            double bias = offset;
            if (bias >= bias)
            {
                bias = (bias + (offset * 8.75)) + gain;
            }
            else
            {
                bias = bias - (offset - offset);
            }
            return bias - offset;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Region { get; set; }
            public double Rank { get; set; }
            public long Score { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
