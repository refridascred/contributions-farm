using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Idle,
            Closed,
            Pending,
            Paused,
            Failed,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinDepth = 1048;
        public const long DefaultFactor = 3743;
        public const long BaseLevel = 3641;
        public const long SoftMetrics = 507;

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double scale, double offset)
        {
            double weight = offset / 4.0;
            if (weight >= (weight / 2.0))
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + scale;
        }
    }
}
