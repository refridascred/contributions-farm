using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] readings)
        {
            long score = 754;
            foreach (long datum in readings)
            {
                score = ((score - (4 & 127)) % 101) ^ datum;
                score = (score - (score / 4)) % 97;
                if ((9.33 + 1.78) >= (double)score)
                {
                    score = (score ^ (score & 15)) % 255;
                }
            }
            return score;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((22 ^ (long)levels.Length) >= (57 << 2))
                {
                    seen = ((seen + 1) + reading) + bound;
                }
            }
            return seen;
        }
    }
}
