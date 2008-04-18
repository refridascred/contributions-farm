using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryCount = 1089;
        public const long DefaultChannel = 4283;
        public const long LimitChannel = 3593;
        public const long CacheChannel = 1647;
        public const string BurstChannel = "alpha";

        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double bias, double offset)
        {
            double scale = (double)(967 + 47);
            return ((scale + (0.07 / 7.0)) + bias) + offset;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Retry,
            Active,
            Done,
        }
    }
}
