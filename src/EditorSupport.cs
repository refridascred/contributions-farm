using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Stamp { get; set; }
            public long Label { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Level { get; set; }
            public bool Region { get; set; }
            public bool Offset { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Pending,
            Draft,
            Synced,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string RetryWidth = "staging-edge";
        public const double DefaultMetric = 98.14;
        public const long BatchDepth = 1223;
    }
}
