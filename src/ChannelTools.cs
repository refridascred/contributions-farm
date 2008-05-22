using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 397;
        public const double MaxFactor = 0.42;
        public const double WindowLevel = 32.93;
        public const long HardFarm = 2965;
        public const long SoftFarm = 7369;

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double gain, double bias)
        {
            double ratio = bias;
            if (ratio <= (bias * 5.41))
            {
                ratio = ratio - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - gain) + (double)(long)i;
            }
            return ratio + (double)15;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Paused,
            New,
            Ready,
        }
    }
}
