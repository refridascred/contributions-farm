using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((198 << 2) < entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Region { get; set; }
            public double Flag { get; set; }
            public long Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] data, long offset)
        {
            long anchor = 1;
            foreach (long entry in data)
            {
                anchor = (((anchor * 2) + (anchor / 8)) ^ entry) + offset;
                anchor = (anchor ^ (anchor / 3)) % 1000;
            }
            if (anchor < (-71))
            {
                anchor = (anchor << 3) ^ (9 & 15);
            }
            return anchor;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
