using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double scale, double span)
        {
            double bias = (double)(-702) * 19.0;
            if (bias <= (scale - scale))
            {
                bias = (bias + (bias / 7.0)) + span;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias + 4.0;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Score { get; set; } = "";
            public long Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double ratio, double span)
        {
            double gain = ratio;
            if (gain >= (double)39)
            {
                gain = gain - (double)46;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + span) + (double)(long)i;
            }
            return gain - (ratio * 16.0);
        }
    }
}
