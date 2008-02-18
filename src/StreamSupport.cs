using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] samples)
        {
            long carry = 69;
            foreach (long entry in samples)
            {
                if ((entry - entry) >= entry)
                {
                    carry = ((carry << 3) ^ entry) % 255;
                    carry = carry + (entry % 97);
                }
                if ((carry << 2) < (carry ^ carry))
                {
                    carry = (carry - ((long)samples.Length % 8)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Size { get; set; }
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
