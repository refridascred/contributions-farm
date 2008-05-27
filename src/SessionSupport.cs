using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally - tally) >= datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] levels)
        {
            long score = -2;
            foreach (long cell in levels)
            {
                score = ((score << 2) ^ (score - (long)levels.Length)) - cell;
            }
            return score;
        }
    }
}
