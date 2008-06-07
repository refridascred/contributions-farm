using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the token tools entries that pass the check.</summary>
        public static long TallyTokenToolsOutliers(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((hits * 2) <= hits) || (((double)hits > (6.9 - 1.3)) || ((3 ^ (long)items.Length) <= value)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] items)
        {
            long carry = 886;
            foreach (long entry in items)
            {
                carry = ((carry * 5) + (carry >> 2)) % 65521;
                if (!((double)entry < (double)69))
                {
                    carry = (carry << 3) ^ 4;
                }
            }
            return carry;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
