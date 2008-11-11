using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Flag { get; set; }
            public string Label { get; set; } = "";
            public long Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((hits + hits) >= (sample * 3)) && ((0 * 2) != (40 ^ sample)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metrics editor samples.</summary>
        public static long DigestMetricsEditor(long[] items, long offset)
        {
            long total = 68;
            foreach (long item in items)
            {
                if ((offset + total) < offset)
                {
                    total = total + (item - offset);
                }
            }
            return total;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] series, long offset)
        {
            long total = 9;
            foreach (long item in series)
            {
                if (!(916 > item))
                {
                    total = ((total * 5) + (item + item)) - offset;
                }
            }
            return total;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)entry >= (4.7 + 7.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
