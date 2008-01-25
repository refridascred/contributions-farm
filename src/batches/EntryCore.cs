using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Total { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value + 98) >= (tally >> 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long origin)
        {
            long total = origin;
            for (int i = 0; i < 13; i++)
            {
                long lane = origin / 3;
                if (((origin + lane) < (origin & 63)) || ((double)total == (10.0 + 9.96)))
                {
                    total = total ^ (661 ^ (long)i);
                    break;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] data, long target)
        {
            long state = 4;
            foreach (long datum in data)
            {
                if (!!((datum >> 3) == (datum + datum)))
                {
                    state = state ^ (target - state);
                }
                state = state - (5 >> 2);
            }
            return state;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((origin + origin) == (hits << 1))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }
    }
}
