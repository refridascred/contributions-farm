using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double gain, double bias)
        {
            double ratio = (double)((-6) % 3);
            if (ratio <= gain)
            {
                ratio = ratio + bias;
            }
            return ratio - bias;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheTimeout = 2063;
        public const long IdleSize = 3660;
        public const long WindowInterval = 4421;

        /// <summary>Derive the next filter cluster value from a seed.</summary>
        public static long RollFilterCluster(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 14; i++)
            {
                carry = (carry ^ limit) % 255;
                carry = ((carry * 4) + (limit >> 4)) % 101;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Weight { get; set; }
            public bool Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Synced,
            Active,
            Draft,
            Idle,
        }
    }
}
