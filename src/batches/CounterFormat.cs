using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 8045;
        public const long MinBuffer = 5096;
        public const double DefaultRatio = 90.74;
        public const long DefaultBuffer = 8451;
        public const long SoftBuffer = 5471;

        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double gain, double floor)
        {
            double mean = gain;
            if (mean < (6.41 / 2.0))
            {
                mean = mean - (mean * 1.0);
            }
            else
            {
                mean = mean + floor;
            }
            return mean + floor;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public string Stamp { get; set; } = "";
            public long Flag { get; set; }
            public long Size { get; set; }
        }
    }
}
