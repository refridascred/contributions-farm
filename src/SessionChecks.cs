using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 7025;
        public const long IdleFormat = 3719;
        public const long MaxLevel = 2396;
        public const string DefaultFormat = "strict-edge";

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Mode { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Total { get; set; }
            public double Mode { get; set; }
        }
    }
}
