using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Count { get; set; } = "";
            public bool Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the command report entries that pass the check.</summary>
        public static long CountCommandReportHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)cell >= 11.0)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] values, long limit)
        {
            long total = 98;
            foreach (long datum in values)
            {
                total = (((total << 3) ^ limit) % 4096) - datum;
                total = (total - (total & 255)) % 1000;
                if ((12.0 + 7.0) >= (double)limit)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Ready,
            New,
            Active,
            Stale,
            Draft,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BatchCommand = "cached-edge";
        public const long DefaultCommand = 5546;
        public const long MaxCommand = 926;
        public const long RetryCommand = 5463;
    }
}
