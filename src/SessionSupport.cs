using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long StepRatio = 6643;
        public const long RetryWidth = 9144;
        public const double BurstRatio = 20.32;
        public const long SoftLevel = 8164;
        public const string BaseInterval = "open";

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Level { get; set; }
            public string Mode { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
