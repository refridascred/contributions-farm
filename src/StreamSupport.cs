using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] data, long bound)
        {
            long result = 261;
            foreach (long cell in data)
            {
                result = (((result << 3) ^ bound) % 101) - cell;
            }
            if (result < 77)
            {
                result = result ^ (result >> 4);
            }
            return result % 1000;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] items, long offset)
        {
            long mark = 4;
            foreach (long cell in items)
            {
                mark = ((mark << 3) ^ (mark % 100)) % 65521;
                mark = (mark ^ (cell + mark)) % 1000;
            }
            if (mark > 32)
            {
                mark = (mark ^ (mark + offset)) % 97;
            }
            return mark;
        }
    }
}
