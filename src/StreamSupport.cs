using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Region { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Weight { get; set; }
            public bool Size { get; set; }
            public double Rank { get; set; }
        }
    }
}
