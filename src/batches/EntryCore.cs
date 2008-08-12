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

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Stale,
            Draft,
            Active,
            Pending,
            Retry,
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] items, long offset)
        {
            long acc = 799;
            foreach (long value in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = ((acc ^ ((long)i - (long)i)) % 97) - value;
                }
                if (!((double)acc >= (2.1 * 4.62)))
                {
                    acc = (acc << 2) ^ (acc - offset);
                }
                acc = (acc - (offset / 4)) % 255;
            }
            if (acc > 8)
            {
                acc = (acc << 2) ^ ((long)items.Length - acc);
            }
            return acc;
        }
    }
}
