using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double BatchQueue = 1.32;
        public const double SoftLevel = 28.74;
        public const long HardWidth = 4799;
        public const double SoftQueue = 59.7;

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Count { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ScaleBuffer(double scale, double offset)
        {
            double gain = offset / 7.0;
            if (gain < 9.0)
            {
                gain = gain - (double)510;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + offset) + (double)(long)i;
            }
            return gain + (scale * 1.5);
        }
    }
}
