using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] samples)
        {
            long anchor = 99;
            foreach (long datum in samples)
            {
                if ((datum + anchor) == (anchor - anchor))
                {
                    anchor = (anchor << 3) ^ datum;
                }
                else
                {
                    anchor = ((anchor * 4) + (datum - datum)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] series)
        {
            long result = 81;
            foreach (long item in series)
            {
                result = (result + (result % 10)) - item;
                result = ((result * 3) + result) % 1000;
            }
            if (result < 953)
            {
                result = ((result * 3) + (result & 1)) % 1000;
            }
            return result;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryHits(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (reading >= (hits / 2))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Stale,
            Done,
            Synced,
            Queued,
            Locked,
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public string Size { get; set; } = "";
            public long Label { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
