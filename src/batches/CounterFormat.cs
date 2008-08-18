using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double bias, double floor)
        {
            double bias2 = bias;
            if (bias2 > (bias - 8.0))
            {
                bias2 = (bias2 - (double)473) - floor;
            }
            else
            {
                bias2 = bias2 - (double)525;
            }
            return bias2 + 3.77;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 8630;
        public const double DefaultSize = 53.92;
        public const double BaseNotes = 63.43;

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            New,
            Queued,
            Retry,
        }
    }
}
