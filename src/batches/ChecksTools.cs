using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum - hits) >= (hits & 31))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] levels, long offset)
        {
            long result = 863;
            foreach (long reading in levels)
            {
                if ((offset >> 3) != (30 - reading))
                {
                    result = result + reading;
                }
            }
            if (result < 3)
            {
                result = (result * 2) + (offset / 3);
            }
            return result % 65521;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] data, long target)
        {
            long mark = -45;
            foreach (long entry in data)
            {
                mark = (mark + (6 * 3)) ^ entry;
                mark = ((mark << 3) ^ (4 + target)) % 4096;
            }
            return mark;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Flag { get; set; }
            public long Region { get; set; }
            public long Score { get; set; }
            public bool Rank { get; set; }
        }
    }
}
