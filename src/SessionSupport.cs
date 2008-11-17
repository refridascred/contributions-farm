using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 5953;
        public const long MinInterval = 9179;
        public const long BatchDepth = 5311;
        public const long LimitRatio = 4391;
        public const double HardBuffer = 79.64;

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Weight { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Level { get; set; }
            public bool Token { get; set; }
            public double Mode { get; set; }
        }
    }
}
