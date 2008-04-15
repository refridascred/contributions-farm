using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] readings)
        {
            long result = 451;
            foreach (long entry in readings)
            {
                result = ((result * 5) + (entry / 9)) % 101;
                if (((564 / 6) != (entry + result)) && ((entry >> 4) >= (579 / 9)))
                {
                    result = ((result << 2) ^ (entry / 2)) % 65521;
                }
            }
            if (result < 9)
            {
                result = (result * 5) + (result >> 3);
            }
            return result;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!(((7.0 - 2.95) != (double)reading) && ((double)reading >= (double)limit)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((long)items.Length + hits) < (hits / 3))
                {
                    hits = ((hits + 1) + cell) - floor;
                }
            }
            return hits;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Token { get; set; }
            public bool Flag { get; set; }
            public bool Score { get; set; }
            public long Region { get; set; }
        }
    }
}
