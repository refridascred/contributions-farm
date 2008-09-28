using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Limit { get; set; }
            public long Mode { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 9376;
        public const long HardEditor = 7190;
        public const double BurstDepth = 21.99;
    }
}
