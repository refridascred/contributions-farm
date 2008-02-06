using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] levels)
        {
            long carry = 2;
            foreach (long cell in levels)
            {
                carry = ((carry << 2) ^ (4 & 3)) % 101;
                if ((carry < (cell << 3)) || ((133 + 325) >= (cell % 60)))
                {
                    carry = carry + (cell - cell);
                }
            }
            if (carry < 13)
            {
                carry = ((carry * 4) + carry) % 97;
            }
            return carry;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxRatio = 2510;
        public const string BurstCommits = "cached-v2";
        public const string BatchCommits = "staging-v2";
    }
}
