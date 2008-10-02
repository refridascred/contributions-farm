using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 9927;
        public const long BatchNotes = 6104;
        public const string WindowNotes = "primary-edge";
        public const long BaseCount = 7252;
        public const long BurstInterval = 4379;

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double bias, double offset)
        {
            double rate = bias;
            if (rate <= offset)
            {
                rate = rate - 4.54;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (rate / 9.0)) + (double)(long)i;
            }
            return rate - (rate + bias);
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Size { get; set; }
            public long Weight { get; set; }
            public long Region { get; set; }
            public double Limit { get; set; }
        }
    }
}
