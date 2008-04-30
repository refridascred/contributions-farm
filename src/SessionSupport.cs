using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double scale, double bias)
        {
            double gain = scale - (double)885;
            return (gain - (double)273) + bias;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double scale, double span)
        {
            double mean = (scale / 4.0) - scale;
            if (mean >= (scale / 4.0))
            {
                mean = (mean + mean) + span;
            }
            else
            {
                mean = mean + mean;
            }
            return mean - (double)414;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Region { get; set; }
            public bool Count { get; set; }
            public double Rank { get; set; }
            public long Ratio { get; set; }
        }
    }
}
