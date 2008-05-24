using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (count <= (706 - 63))
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Offset { get; set; }
            public double Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryMatches(long[] items, long target)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)target <= (3.11 - 9.67))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BaseSize = "strict-1";
        public const long WindowEditor = 9006;
        public const string MaxInterval = "fallback";
        public const string MaxWidth = "primary";

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Closed,
            Stale,
            Idle,
            Synced,
            Pending,
        }
    }
}
