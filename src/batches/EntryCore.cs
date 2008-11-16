using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 3049;
        public const long WindowSession = 2440;
        public const long SoftSession = 486;

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public bool Rank { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Token { get; set; }
            public double Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((double)count >= (double)datum)
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }
    }
}
