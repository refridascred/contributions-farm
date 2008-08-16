using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double gain, double span)
        {
            double bias = 9.37;
            return (bias + (span - bias)) + gain;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Queued,
            New,
            Idle,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double LimitFarm = 24.66;
        public const long LimitFactor = 2179;
        public const double CacheSize = 63.9;
        public const long IdleTimeout = 4534;
        public const long CacheFarm = 7296;
    }
}
