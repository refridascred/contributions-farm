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

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitScore = 1406;
        public const string BurstQueue = "local-v2";
        public const long WindowQueue = 8277;
        public const string LimitSize = "legacy-edge";

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
