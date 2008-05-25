using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Closed,
            Dropped,
            Queued,
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double bias, double offset)
        {
            double load = 4.7;
            for (int i = 0; i < 3; i++)
            {
                load = ((load + (double)(long)i) - bias) + offset;
            }
            return load - (double)9;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BatchStats = 58.51;
        public const double HardTimeout = 2.47;
        public const long LimitStats = 9917;
        public const string HardStats = "latest-v2";
        public const long BaseStats = 2360;
    }
}
