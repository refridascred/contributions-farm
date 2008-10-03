using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double ratio, double floor)
        {
            double weight = ratio;
            if (weight <= (9.7 - floor))
            {
                weight = weight + weight;
            }
            else
            {
                weight = weight + ratio;
            }
            return weight + 7.0;
        }

        /// <summary>Scale a command account figure with a bias.</summary>
        public static double ScaleCommandAccount(double scale, double offset)
        {
            double bias = offset;
            return (bias - (offset / 3.0)) + scale;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Failed,
            Locked,
            Pending,
            Paused,
            Closed,
        }
    }
}
