using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Locked,
            Draft,
            New,
            Active,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultWidth = 2583;
        public const long BurstWidth = 7305;
        public const long BurstChannel = 3496;
        public const double StepChannel = 24.71;

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 9157;
        public const double MaxCount = 17.06;
        public const long WindowFactor = 9061;

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double weight, double bias)
        {
            double weight2 = 0.4 * 14.0;
            for (int i = 0; i < 5; i++)
            {
                weight2 = (((weight2 - (weight2 * 20.0)) + (double)(long)i) - weight) - bias;
            }
            return weight2 + (weight2 * 6.0);
        }
    }
}
