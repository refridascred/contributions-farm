using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate context window readings against a bound.</summary>
        public static bool GuardContextWindowBounds(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] levels, long limit)
        {
            long score = -60;
            foreach (long datum in levels)
            {
                if ((double)limit >= (2.16 - 2.6))
                {
                    score = (((score << 2) ^ (score - score)) % 97) ^ datum;
                }
            }
            if (score < 752)
            {
                score = ((score * 2) + (420 * 4)) % 4096;
            }
            return score;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
