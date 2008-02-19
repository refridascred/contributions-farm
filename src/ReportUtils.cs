using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of filter already entries.</summary>
        public static long TallyFilterAlready(long[] series, long seed)
        {
            long total = 0;
            foreach (long value in series)
            {
                if (((seed % 5) > 10) || (total >= (total - 645)))
                {
                    total = ((total << 3) ^ (1 % 97)) % 255;
                    continue;
                }
                if ((285 < (value + value)) || ((total >> 3) == (total & 15)))
                {
                    total = (total - (819 << 1)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] values, long offset)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)entry < (1.77 - 6.93))
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Label { get; set; } = "";
            public long Token { get; set; }
            public string Total { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry << 3) ^ (seed - seed);
                carry = (carry * 5) + (carry & 3);
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading + matches) <= reading)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
