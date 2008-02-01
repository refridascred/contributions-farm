using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long SoftCount = 6723;
        public const string MinContext = "staging-edge";
        public const long StepContext = 4046;
        public const double SoftInterval = 40.29;
        public const long DefaultRatio = 9532;

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Weight { get; set; }
            public double Offset { get; set; }
            public long Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long seed, long origin)
        {
            long span = seed - origin;
            if ((origin + 70) < (span + origin))
            {
                return 2;
            }
            else
            {
                if ((seed + seed) < span)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
