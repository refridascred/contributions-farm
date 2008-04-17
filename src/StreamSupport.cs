using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double gain, double span)
        {
            double drift = (2.09 - span) + (double)15;
            return (drift - (span * 6.7)) + gain;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Dropped,
            Pending,
            Closed,
            New,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 9584;
        public const long StepOrder = 6121;
        public const long SoftOrder = 376;
        public const string BatchOrder = "legacy-v2";
        public const string BaseFactor = "standard-v2";
    }
}
