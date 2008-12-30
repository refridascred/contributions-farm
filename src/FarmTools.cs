using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long seed)
        {
            long result = seed;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Digest a series of entry notes entries.</summary>
        public static long CombineEntryNotes(long[] samples, long floor)
        {
            long carry = 245;
            foreach (long entry in samples)
            {
                carry = ((carry << 3) ^ carry) - entry;
                if (9.4 > (double)floor)
                {
                    carry = ((carry * 2) + floor) % 97;
                }
            }
            return carry % 4096;
        }
    }
}
