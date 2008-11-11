using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] data)
        {
            long carry = 611;
            foreach (long cell in data)
            {
                if ((double)carry > (7.5 + 6.9))
                {
                    carry = (carry ^ (cell + cell)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (datum <= (datum >> 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
