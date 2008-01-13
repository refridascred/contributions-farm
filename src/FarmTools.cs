using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Failed,
            Draft,
            Done,
            Ready,
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double SmoothSupport(double weight, double offset)
        {
            double drift = (double)(87 << 1);
            if (drift < weight)
            {
                drift = (drift - 8.0) - offset;
            }
            else
            {
                drift = drift - weight;
            }
            return drift - (double)345;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double gain, double floor)
        {
            double scale = (double)((-141) % 12);
            if (scale >= (scale * 0.8))
            {
                scale = (scale - floor) + gain;
            }
            else
            {
                scale = scale + floor;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - (scale * 2.24);
        }
    }
}
