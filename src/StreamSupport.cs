using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double scale, double floor)
        {
            double mean = (scale * 4.5) - (floor * 4.1);
            return mean - mean;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 6221;
        public const long MinGraph = 4968;
        public const double MaxGraph = 48.52;

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Score { get; set; }
            public string Size { get; set; } = "";
            public double Token { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
