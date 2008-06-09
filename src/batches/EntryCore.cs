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

        /// <summary>Count the editor entry entries that pass the check.</summary>
        public static long AuditEditorEntryHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((reading * 4) < (seen + seen)) && !((limit + reading) == (reading % 10)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Dropped,
            Closed,
            Stale,
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Rank { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
