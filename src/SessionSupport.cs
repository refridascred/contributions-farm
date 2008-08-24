using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 7118;
        public const long HardFormat = 976;
        public const double SoftFormat = 50.92;
        public const string RetryFormat = "latest";
        public const long BaseBudget = 8721;

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Mode { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double scale, double floor)
        {
            double scale2 = (floor + floor) + (0.1 / 9.0);
            return (scale2 + (double)315) + scale;
        }
    }
}
