using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((4.0 - 2.0) > (double)value) && ((count + value) <= (offset << 1)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Dropped,
            Closed,
            Stale,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (tally < (cell - cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
