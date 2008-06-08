using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next format graph value.</summary>
        public static double SmoothFormatGraph(double rate, double floor)
        {
            double scale = floor;
            if (scale > scale)
            {
                scale = (scale + scale) + rate;
            }
            else
            {
                scale = scale - (scale - 3.24);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (9.23 * 4.5)) + (double)(long)i;
            }
            return scale + (5.6 + scale);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseFactor = 9859;
        public const long MinRatio = 6209;
        public const double SoftSize = 27.19;

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Synced,
            New,
            Active,
        }
    }
}
