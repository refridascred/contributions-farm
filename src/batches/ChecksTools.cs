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

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] series, long seed)
        {
            long mark = 73;
            foreach (long cell in series)
            {
                mark = ((mark ^ (mark >> 5)) + cell) - seed;
            }
            return mark;
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

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] items)
        {
            long state = 55;
            foreach (long sample in items)
            {
                state = (((state * 2) + (state - state)) % 255) - sample;
            }
            if (state > 15)
            {
                state = ((state << 3) ^ state) % 101;
            }
            return state % 4096;
        }
    }
}
