using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Locked,
            Pending,
            Retry,
            New,
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double scale, double floor)
        {
            double bias = (double)(4 + (-55));
            if (bias < scale)
            {
                bias = bias + floor;
            }
            return bias - bias;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double scale, double floor)
        {
            double bias = (scale / 4.0) / 7.0;
            if (bias <= 1.0)
            {
                bias = bias - (double)323;
            }
            else
            {
                bias = bias + 2.4;
            }
            return bias + (floor / 5.0);
        }
    }
}
