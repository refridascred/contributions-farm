using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double scale, double bias)
        {
            double gain = scale - (double)885;
            return (gain - (double)273) + bias;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Total { get; set; }
            public string Mode { get; set; } = "";
            public string Offset { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftDepth = 910;
        public const long IdleScore = 554;
        public const long StepFactor = 5768;
        public const long DefaultSpan = 335;
        public const string SoftTimeout = "standard-1";
    }
}
