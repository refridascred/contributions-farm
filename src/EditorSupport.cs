using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Dropped,
            New,
            Retry,
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Dropped,
            Synced,
            Paused,
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Stale,
            Retry,
            Ready,
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Draft,
            Idle,
            Pending,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] readings, long floor)
        {
            long anchor = 651;
            foreach (long datum in readings)
            {
                anchor = (((anchor * 4) + (datum + 2)) % 97) - floor;
            }
            return anchor % 1000;
        }
    }
}
