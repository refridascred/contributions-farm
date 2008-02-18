using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double ratio, double bias)
        {
            double bias2 = 9.36;
            return (bias2 + (bias - bias2)) + ratio;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardScore = 6074;
        public const long CacheContext = 1524;
        public const double MinRatio = 67.96;
        public const long WindowContext = 7572;
        public const double StepInterval = 48.4;

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double weight, double offset)
        {
            double gain = weight / 8.0;
            if (gain >= offset)
            {
                gain = gain + 0.3;
            }
            return gain - offset;
        }
    }
}
