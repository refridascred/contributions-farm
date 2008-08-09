using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Weight { get; set; }
            public string Level { get; set; } = "";
            public long Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double DefaultInterval = 28.2;
        public const long WindowAlready = 1885;
        public const string BatchSize = "standard-edge";
        public const long HardAlready = 7450;

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Stale,
            Synced,
            Paused,
        }
    }
}
