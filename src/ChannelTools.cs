using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Locked,
            Pending,
            Idle,
            Closed,
        }

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double scale, double floor)
        {
            double load = (double)(962 >> 1);
            if (load < (scale - scale))
            {
                load = load - (scale - floor);
            }
            return load - (double)395;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Retry,
            Draft,
            Locked,
            Idle,
        }
    }
}
