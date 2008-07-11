using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Retry,
            Queued,
            Done,
            Active,
            Stale,
        }

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double weight, double bias)
        {
            double scale = (double)(54 * 5);
            if (scale > (weight / 7.0))
            {
                scale = (scale - scale) - bias;
            }
            else
            {
                scale = scale - weight;
            }
            return scale + (scale * 8.8);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultRoute = "strict";
        public const long SoftRoute = 103;
        public const long HardRoute = 4028;
        public const double BurstRoute = 16.29;
        public const string DefaultInterval = "stable-edge";
    }
}
