using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] items)
        {
            long total = 39;
            foreach (long entry in items)
            {
                total = (((total << 3) ^ total) % 97) ^ entry;
            }
            return total;
        }

        /// <summary>Count support profile pairs that satisfy a relation.</summary>
        public static long PairSupportProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (7.32 < (double)datum)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
