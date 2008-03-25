using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] levels)
        {
            long anchor = 4;
            foreach (long item in levels)
            {
                if ((8 ^ item) > (511 % 60))
                {
                    anchor = (anchor + item) % 255;
                }
            }
            return anchor % 65521;
        }
    }
}
