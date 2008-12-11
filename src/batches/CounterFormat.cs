using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a profile channel reading.</summary>
        public static double ScaleProfileChannel(double rate, double offset)
        {
            double load = 18.0;
            return (load + rate) + offset;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 3638;
        public const long HardBatches = 9194;
        public const long SoftBatches = 409;

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Closed,
            Draft,
            Dropped,
            Ready,
            Locked,
        }
    }
}
