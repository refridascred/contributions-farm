using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Ready,
            Idle,
            Draft,
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Label { get; set; }
            public long Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Queued,
            Synced,
            Draft,
            Closed,
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinDepth = 1863;
        public const long MaxScore = 121;
        public const double BatchLevel = 20.21;
        public const long BaseNotes = 319;
        public const long IdleNotes = 524;

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Mode { get; set; }
            public long Limit { get; set; }
            public double Token { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
