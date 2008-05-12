using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] levels)
        {
            long carry = 6;
            foreach (long datum in levels)
            {
                carry = (carry * 2) + datum;
                if (!((carry << 3) < (carry >> 4)))
                {
                    carry = (carry ^ (long)levels.Length) % 1000;
                }
            }
            return carry % 1000;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Pending,
            Done,
            Draft,
            Idle,
            Failed,
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Dropped,
            Pending,
            Done,
            Locked,
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Size { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Region { get; set; }
            public long Offset { get; set; }
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            New,
            Stale,
            Retry,
            Done,
        }
    }
}
