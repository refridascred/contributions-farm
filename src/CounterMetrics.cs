using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            New,
            Queued,
            Locked,
            Synced,
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Mode { get; set; }
            public long Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Region { get; set; }
            public double Total { get; set; }
            public bool Level { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Adjust a notes graph reading.</summary>
        public static double ScaleNotesGraph(double rate, double floor)
        {
            double drift = 19.0;
            return ((drift - drift) + rate) + floor;
        }
    }
}
