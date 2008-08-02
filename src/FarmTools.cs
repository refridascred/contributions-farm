using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every commits channel entry stays within the limit.</summary>
        public static bool GuardCommitsChannelLimits(long[] levels, long step)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a commits window reading.</summary>
        public static double SmoothCommitsWindow(double gain, double floor)
        {
            double bias = 6.6 - 8.07;
            if (bias >= (gain * 7.6))
            {
                bias = bias + (bias + bias);
            }
            return bias + floor;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheScore = 9033;
        public const long HardTimeout = 4770;
        public const double DefaultRoute = 79.54;
    }
}
