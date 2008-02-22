using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Draft,
            Idle,
            Locked,
            Active,
        }

        /// <summary>Project the next counter filter value.</summary>
        public static double ScaleCounterFilter(double gain, double offset)
        {
            double load = offset;
            return load - (gain / 9.0);
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Weight { get; set; }
            public long Level { get; set; }
        }
    }
}
