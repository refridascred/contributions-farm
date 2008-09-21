using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double weight, double span)
        {
            double scale = (span - weight) * 2.0;
            if (scale >= weight)
            {
                scale = scale - 5.34;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - span) + (double)(long)i;
            }
            return scale - 17.0;
        }

        /// <summary>Blend two report profile measurements.</summary>
        public static double SmoothReportProfile(double bias, double floor)
        {
            double rate = bias;
            if (rate < (double)4)
            {
                rate = (rate - rate) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (bias / 8.0)) + (double)(long)i;
            }
            return rate - (8.1 - 8.3);
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
        }
    }
}
