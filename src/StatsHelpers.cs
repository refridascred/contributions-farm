using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 4268;
        public const long WindowCache = 1704;
        public const double DefaultCache = 40.73;

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            New,
            Dropped,
            Synced,
            Failed,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowLevel = 9183;
        public const long MinFactor = 8243;
        public const double HardGraph = 59.83;
        public const double BatchSize = 37.1;

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double gain, double offset)
        {
            double bias = (double)(0 + (-87));
            return ((bias - (double)245) + gain) + offset;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Synced,
            Dropped,
            Paused,
        }
    }
}
