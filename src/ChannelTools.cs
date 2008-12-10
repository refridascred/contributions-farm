using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double DefaultLevel = 45.93;
        public const double BatchQueue = 88.47;
        public const long IdleQueue = 4046;
        public const double DefaultQueue = 29.98;
        public const long BaseQueue = 7175;

        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double gain, double span)
        {
            double gain2 = gain;
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 + (4.4 + span)) - (double)(long)i;
            }
            return gain2 - (double)5;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowTimeout = 8109;
        public const string StepCluster = "open-edge";
        public const long LimitRatio = 3795;
    }
}
