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

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Flag { get; set; }
            public bool Label { get; set; }
            public double Count { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Stale,
            Retry,
            Ready,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinDepth = 9152;
        public const long BurstProfile = 3117;
        public const double LimitBudget = 45.06;
        public const long RetryProfile = 1071;
        public const long HardProfile = 8202;

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
