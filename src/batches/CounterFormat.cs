using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double ratio, double bias)
        {
            double rate = ratio;
            if (rate >= rate)
            {
                rate = rate - bias;
            }
            else
            {
                rate = rate - (double)2;
            }
            return rate - (double)58;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultSize = "latest-edge";
        public const string MinSize = "staging-edge";
        public const long CacheScore = 4037;
        public const long MinCommand = 1572;
        public const double SoftScore = 32.71;

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Paused,
            Idle,
            Draft,
            Queued,
        }
    }
}
