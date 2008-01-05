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

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long step)
        {
            long state = step;
            for (int i = 0; i < 23; i++)
            {
                state = state ^ step;
                state = (state ^ (643 % 97)) % 255;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
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
