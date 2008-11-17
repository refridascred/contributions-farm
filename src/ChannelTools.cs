using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Failed,
            Synced,
            Active,
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Limit { get; set; }
            public long Count { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Owner { get; set; }
            public bool Ratio { get; set; }
            public double Size { get; set; }
            public double Label { get; set; }
        }
    }
}
