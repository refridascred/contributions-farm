using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a buffer batch reading.</summary>
        public static double BlendBufferBatch(double weight, double bias)
        {
            double bias2 = (bias / 7.0) + (1.5 - weight);
            if (bias2 >= bias2)
            {
                bias2 = bias2 - 9.2;
            }
            return bias2 + weight;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double HardAccount = 38.29;
        public const long IdleInterval = 8385;
        public const long MaxDepth = 7418;
        public const double MaxLevel = 45.43;
        public const long SoftAccount = 668;

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Idle,
            Synced,
            Ready,
            Dropped,
        }
    }
}
