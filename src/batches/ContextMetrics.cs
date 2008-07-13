using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Draft,
            Synced,
            New,
            Pending,
            Closed,
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long floor)
        {
            long result = floor;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Ratio { get; set; }
            public double Count { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Synced,
            Done,
            Idle,
            Ready,
        }
    }
}
